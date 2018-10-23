// ver 1.0.0
/*
 WARN: SINCE WRONG GIT BRANCH, HERE SHOULD ONLY CHENGE ONE SECTION WITH COMMENT BUG WHEN MERGE BACK TO MASTER
 1. after received data, ack didnt return properly.
 2. esp8266 still send its at+cipsend here, this occur same time with 1. .
 3. (maybe solved, this may caused by esp8266 didnt sent proper data since we use pared data to start the   timer)timer doesnt start even the training is started (sametime error with 1. 2.)

 TODO:
 1. Switch magic number to macro-like style.
 2. Rat route record need a better implementation, may involve mcu-end arch.
 
 
 */

using System;
using System.Windows.Forms;
using System.Text;
using System.Net;
using System.Net.Sockets;
using System.Linq;
using System.Drawing;
using System.IO;
using System.Threading;
using System.IO.Ports;
using System.Collections.Generic;

namespace Maze_3_arm
{
    
    
    
    public partial class Form1 : Form
    {
        //Socket serverFd;
        IPEndPoint serverIpInfo = new IPEndPoint(IPAddress.Parse("192.168.4.2"), 62222);
        IPEndPoint remoteIpInfo = new IPEndPoint(IPAddress.Parse("192.168.4.1"), 3232);
        EndPoint Remote;
        byte[] receiveDataList = new byte[64]; 
        byte[] dataBuffer       = new byte[100];
        byte[] sendBuffer       = new byte[7] { 0, 0, 0, 0, (byte)'R', (byte)'D', (byte)'Y' };
        ushort[] DACtable = new ushort[3] { 0x020d, 0x041a, 0x0628 }; /* speed from low to high as index from 0 ~ max */
        byte[] DACspeed = new byte[6] { 0, 0, 0, 0, 0, 0 };
        StreamWriter resultStreamWriter;
        static ThreadStart recvThread = new ThreadStart(Work.taskRecvThread);
        Thread newThread = new Thread(recvThread);
        bool isTrainingFisrtTime = true;
        ushort ratRouteIndex = 18;
        uint timerCount = 0;

        SerialPort serialPort = new SerialPort();
        //List<Byte> receiveDataList = new List<Byte>();
        char[] knockDoorConst = new char[3] { 'R', 'D', 'Y' };
        ushort dReceiveSize;
        byte timeoutCount = 0;

        module_Info arm_Info;
        public void DoRemoteIpInfoCast()
        {
            Remote = (EndPoint)remoteIpInfo; /* receiveFrom use this as its arg */
        }
        public enum connectionStatus
        {
            UNCONNECT = 1,
            CONNECTED,
            CONNECTED_KNOCK_DOOR,
            CONNECTED_KNOCK_DOOR_WAIT, /* used in uart mode */           
            END_TRAINING_IN_PROGRESS, /* used in uart mode */
            END_TRAINING_WAIT_PROGRESS, /* used in uart mode */
            TRAINING_END /* used in uart mode */
        }
        public enum mazeStatus
        {
            WAIT_FOR_RAT = 1,
            RAT_NOT_ENTERED,
            RAT_ENTERED,
            TRAINING_END
        }
        public enum trainingStatus
        {
            STANDBY = 6,
            RUNNING,
            COMPLETE         
        }
        public struct module_Info
        {
            public short[]          shortTermError;
            public short[]          longTermError;
            public short            food_left;
            public trainingStatus   trainState;
            public connectionStatus netState;
            public bool isDataReceived; /* this flag determine wheather receive the incoming data */
        }
        
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string[] ports = SerialPort.GetPortNames();
            serialPortSelect.Items.AddRange(ports);
            //recvBuffer1 = 3;
            //recvBuffer[16] = 4;            
            //recvBuffer[0] = 1;
            //Array.Clear(recvBuffer, 0, recvBuffer.Length);
            // value cast success connectionState.Text = recvBuffer[0].ToString();
            globalBuffer.g_isThreadWorking = false;
            //newThread.Start();            
            arm_Info.trainState     = trainingStatus.STANDBY;
            arm_Info.netState       = connectionStatus.CONNECTED_KNOCK_DOOR; /* CHANGEED FOR UART TRANSMISSION */
            arm_Info.isDataReceived = false;
            globalBuffer.g_dataNeedProcess = false;
            //DoRemoteIpInfoCast();   /* init variable since it cast a var which initialize with _new_, so with func call, we can guarantee that its been initialized */
            /* enable network timer and do a regular check to network state */
            networkTimer.Interval   = 100;

            //dReceiveSize = 3; /* this is to receive ACK, then it shall change to 64 */
        }

        private void onSerialPortReceive(Object sender, SerialDataReceivedEventArgs e)
        {
            try
            {
                if (globalBuffer.g_dataNeedProcess)
                    return;
                //debug = true;
                Byte[] buffer = new Byte[64]; /* WARN: once checksum added, the buffer size should increase */
                int length = (sender as SerialPort).Read(buffer, 0, buffer.Length);
                for (int i = 0; i < length; i++)
                {
                    receiveDataList[i] = buffer[i];
                }
                globalBuffer.g_dataNeedProcess = true;
                //debug2++;
               // debug = false;
                //if ((arm_Info.netState == connectionStatus.CONNECTED_KNOCK_DOOR_WAIT) || arm_Info.netState == connectionStatus.CONNECTED_KNOCK_DOOR)
                //   dReceiveSize = 64;/* change buffer size ASAP to fit 64 bytes data from mcu, another method is delay mcu */
            }
            catch
            {
                serialPort.Close();
            }
        }

        private void networkTimer_Tick(object sender, EventArgs e)
        {
           
           switch (arm_Info.netState)
           {                
                case connectionStatus.CONNECTED_KNOCK_DOOR:
                    /*
                    try
                    {
                        globalBuffer.g_recvSocketfd.SendTo(sendBuffer, 6, SocketFlags.None, remoteIpInfo); /* send first packet to remote, which the data sent is "rd" 
                        //globalBuffer.g_recvSocketfd.ReceiveFrom(recvBuffer, 0, 3, SocketFlags.None, ref Remote);
                    }
                    catch (Exception ex)
                    {
                        errorBox.Text = ex.ToString();
                        break; /* re-knock the door 
                    }
                    
                    Array.Clear(recvBuffer, 0, recvBuffer.Length);
                    */
                    serialPort.Write(sendBuffer, 0, 7);
                    arm_Info.netState = connectionStatus.CONNECTED_KNOCK_DOOR_WAIT;                    
                    //connectionState.Text = "CONNECTED"; /* change color to green here */
                    //globalBuffer.g_isThreadWorking = true;
                    // THIS CANT BE HERE, SHOULD AFTER KNOCK_DOOR CHECK arm_Info.netState = connectionStatus.CONNECTED;
                    break;
                case connectionStatus.CONNECTED_KNOCK_DOOR_WAIT:
                    if (!globalBuffer.g_dataNeedProcess)
                    {
                        timeoutCount++;
                        if (timeoutCount >= 3)
                        {
                            timeoutCount = 0;
                            arm_Info.netState = connectionStatus.CONNECTED_KNOCK_DOOR;
                        }
                    }
                    else
                    {
                        ratRoute.Text = "";
                        timeoutCount = 0; /* prepare for next use */
                        connectionState.Text = "Connected";
                        arm_Info.netState = connectionStatus.CONNECTED;
                        globalBuffer.g_dataNeedProcess = false;                        
                        //dReceiveSize = 64; /* to receive training data */                        
                        Array.Clear(receiveDataList, 0, receiveDataList.Length);
                        timerTimeElapsed.Enabled = true;
                        stopButton.Enabled = true;
                    }
                    break;
                case connectionStatus.CONNECTED:
                    /*
                    try
                    {
                        serverFd.ReceiveFrom(recvBuffer, 0, 64, SocketFlags.None, ref Remote);
                    }
                    catch (Exception ex)
                    {
                        errorBox.Text = ex.ToString();
                        break;
                    }
                    */
                    if (!globalBuffer.g_dataNeedProcess)
                        break; /* break due to no data need process */
                    /*
                    if (debug)
                    {
                        globalBuffer.g_dataNeedProcess = false;
                        Array.Clear(receiveDataList, 0, receiveDataList.Length);
                        break;
                    }
                    */
                    if (ratRouteIndex < 64) /* 64 is recv buffer max index */
                    {
                        if (receiveDataList[ratRouteIndex] != 0)
                        {
                            ratRoute.Text += (receiveDataList[ratRouteIndex]).ToString() + " ";                            
                            resultStreamWriter.Write(receiveDataList[ratRouteIndex].ToString() + " ");
                            ratRouteIndex++;
                        }
                    }                    

                    for (short i = 1; i <= 16; i += 2)
                    {
                        switch (i)
                        {
                            case 1:                                
                                longTerm1.Text = receiveDataList[i].ToString();
                                shortTerm1.Text = receiveDataList[i + 1].ToString();
                                break;
                            case 3:
                                longTerm2.Text = receiveDataList[i].ToString();
                                shortTerm2.Text = receiveDataList[i + 1].ToString();
                                break;
                            case 5:
                                longTerm3.Text = receiveDataList[i].ToString();
                                shortTerm3.Text = receiveDataList[i + 1].ToString();
                                break;
                            case 7:
                                longTerm4.Text = receiveDataList[i].ToString();
                                shortTerm4.Text = receiveDataList[i + 1].ToString();
                                break;
                            case 9:
                                longTerm5.Text = receiveDataList[i].ToString();
                                shortTerm5.Text = receiveDataList[i + 1].ToString();
                                break;
                            case 11:
                                longTerm6.Text = receiveDataList[i].ToString();
                                shortTerm6.Text = receiveDataList[i + 1].ToString();
                                break;
                            case 13:
                                longTerm7.Text = receiveDataList[i].ToString();
                                shortTerm7.Text = receiveDataList[i + 1].ToString();
                                break;
                            case 15:
                                longTerm8.Text = receiveDataList[i].ToString();
                                shortTerm8.Text = receiveDataList[i + 1].ToString();
                                break;
                        }
                    }
                    short buffer = 0;
                    for (short i = 1; i < 16; i += 2)
                    {
                        buffer += receiveDataList[i];
                    }
                    totalLongTerm.Text = buffer.ToString();
                    buffer = 0;
                    for (short i = 2; i <= 16; i += 2)
                    {
                        buffer += receiveDataList[i];
                    }
                    totalShortTerm.Text = buffer.ToString();
                    foodAte.Text = receiveDataList[17].ToString();                    
                    switch (receiveDataList[0]) /* handle this since it's better to change the state */
                    {
                        case (byte)mazeStatus.WAIT_FOR_RAT:
                            mazeState.Text = "Wait for rat";
                            break;
                        case (byte)mazeStatus.RAT_ENTERED:
                            mazeState.Text = "Rat entered arm";
                            break;
                        case (byte)mazeStatus.RAT_NOT_ENTERED:
                            if (isTrainingFisrtTime)
                            {
                                isTrainingFisrtTime = false;
                                timerTimeElapsed.Enabled = true;
                            }
                            mazeState.Text = "Rat not entered";
                            break;
                        case (byte)mazeStatus.TRAINING_END:
                            mazeState.Text = "Training end";
                            timerTimeElapsed.Enabled = false;
                            startButton.BackColor = Color.LawnGreen;
                            arm_Info.netState = connectionStatus.END_TRAINING_IN_PROGRESS;                           
                            break;
                    }
                    globalBuffer.g_dataNeedProcess = false;
                    serialPort.Write(new char[3] { 'A', 'C', 'K' }, 0, 3);
                    //Array.Clear(globalBuffer.g_recvBuffer, 0, globalBuffer.g_recvBuffer.Length);
                    //arm_Info.netState = connectionStatus.CONNECTED;                    
                    if (arm_Info.netState != connectionStatus.END_TRAINING_IN_PROGRESS) /* we have ACK from MCU at END_TRAINING_IN_PROGRESS state, don't erase it */
                    {
                        Array.Clear(receiveDataList, 0, receiveDataList.Length);
                    }
                    break;
                case connectionStatus.END_TRAINING_IN_PROGRESS:
                    serialPort.Write(new char[3] {'E','N','D'}, 0, 3); // last 3 bytes are used to fill buffer to 6 byte, this is due to a infrastructure problem, it deserve better implementation TODO
                    arm_Info.netState = connectionStatus.END_TRAINING_WAIT_PROGRESS;
                    break;
                case connectionStatus.END_TRAINING_WAIT_PROGRESS:
                    if (!globalBuffer.g_dataNeedProcess)
                    {
                        timeoutCount++;
                        if (timeoutCount >= 3)
                        {
                            timeoutCount = 0;
                            arm_Info.netState = connectionStatus.END_TRAINING_IN_PROGRESS;
                        }
                    }
                    else
                    {
                        timeoutCount = 0;
                        //if (receiveDataList[0] != 'A' || receiveDataList[1] != 'C') SINCE OUR RECV BUFFER GOT WERIED OFFSET (DATA AT STRANGE POS INSIDE BUFFER), WE CHANGE THIS TO ONCE RECEIVED 3 BYTES
                        //{
                        //    arm_Info.netState = connectionStatus.END_TRAINING_IN_PROGRESS;
                        //    break;
                        //}
                        arm_Info.netState = connectionStatus.TRAINING_END; /* training end state switched here */
                    }
                    break;
                case connectionStatus.TRAINING_END:
                    timerCount = 0; /* time counting */
                    resultStreamWriter.Write(Environment.NewLine + "Total long term: " + totalLongTerm.Text);
                    resultStreamWriter.Write(Environment.NewLine + "Total short term: " + totalShortTerm.Text);
                    resultStreamWriter.Write(Environment.NewLine + "Total training time: " + timeElapsed.Text);
                    resultStreamWriter.WriteLine();
                    resultStreamWriter.WriteLine();
                    resultStreamWriter.Flush();
                    serialPort.Close();
                    ratRouteIndex = 18;
                    resultStreamWriter.Close();
                    Array.Clear(receiveDataList, 0, receiveDataList.Length);
                    trainingState.Text = "Training end";
                    mazeState.Text = "Wait for rat";
                    startButton.BackColor = Color.LawnGreen;
                    Console.Beep(1000, 1500);
                    //Thread.Sleep(1000);
                    //Console.Beep(1000, 1500);
                    globalBuffer.g_dataNeedProcess = false;
                    networkTimer.Enabled = false;
                    stopButton.Enabled = false;
                    break;                                    
           }
        }

        private void pathSelectButton_Click(object sender, EventArgs e)
        {
            resultFileDialog.ShowDialog();
        }

        private void resultFileDialog_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {
            resultFilePath.ForeColor = Color.Black;
            resultFilePath.Text = resultFileDialog.FileName;
        }

        private void startButton_Click(object sender, EventArgs e)
        {              
            
            try
            {
                serialPortSelect.ForeColor = SystemColors.WindowText;
                serialPort.PortName = serialPortSelect.Text;
                serialPort.DataBits = 8;
                serialPort.Parity = Parity.None;
                serialPort.StopBits = StopBits.One;
                serialPort.BaudRate = 115200;
            }
            catch
            {
                serialPortSelect.ForeColor = Color.Red;
                serialPortSelect.Text = "Port error";
                return;
            }
            
            try
            {
                serialPortSelect.ForeColor = SystemColors.WindowText;
                serialPort.Open();
                serialPort.DiscardOutBuffer();
                serialPort.DiscardInBuffer();
                serialPort.DataReceived += new SerialDataReceivedEventHandler(onSerialPortReceive);
            }
            catch
            {
                serialPortSelect.ForeColor = Color.Red;
                serialPortSelect.Text = "Port error";
                return;
            }
            
            ushort bufferIndex = 0;
            while (true)    /* this part is extremly hard-coded */
            {
                if (checkBoxArmLoc0.Checked)
                {
                    sendBuffer[bufferIndex] = 0;
                    bufferIndex++;
                    if (bufferIndex == 4)
                        break;
                }
                if (checkBoxArmLoc1.Checked)
                {
                    sendBuffer[bufferIndex] = 1;
                    bufferIndex++;
                    if (bufferIndex == 4)
                        break;
                }
                if (checkBoxArmLoc2.Checked)
                {
                    sendBuffer[bufferIndex] = 2;
                    bufferIndex++;
                    if (bufferIndex == 4)
                        break;
                }
                if (checkBoxArmLoc3.Checked)
                {
                    sendBuffer[bufferIndex] = 3;
                    bufferIndex++;
                    if (bufferIndex == 4)
                        break;
                }
                if (checkBoxArmLoc4.Checked)
                {
                    sendBuffer[bufferIndex] = 4;
                    bufferIndex++;
                    if (bufferIndex == 4)
                        break;
                }
                if (checkBoxArmLoc5.Checked)
                {
                    sendBuffer[bufferIndex] = 5;
                    bufferIndex++;
                    if (bufferIndex == 4)
                        break;
                }
                if (checkBoxArmLoc6.Checked)
                {
                    sendBuffer[bufferIndex] = 6;
                    bufferIndex++;
                    if (bufferIndex == 4)
                        break;
                }
                if (checkBoxArmLoc7.Checked)
                {
                    sendBuffer[bufferIndex] = 7;
                    bufferIndex++;
                    if (bufferIndex == 4)
                        break;
                }
                errorBox.ForeColor = Color.Red;
                errorBox.Text = "Arm with food didn't check properly";
                return;
            }
            try
            {                
                resultStreamWriter = new StreamWriter(resultFileDialog.FileName, true);
            }
            catch
            {
                resultFilePath.Text = "File path error";
                resultFilePath.ForeColor = Color.Red;
                return;
            }
            bufferIndex = 0;
            resultStreamWriter.Write("Arm with food: ");
            resultStreamWriter.Write((sendBuffer[bufferIndex++] + 1).ToString() + " ");
            resultStreamWriter.Write((sendBuffer[bufferIndex++] + 1).ToString() + " ");
            resultStreamWriter.Write((sendBuffer[bufferIndex++] + 1).ToString() + " ");
            resultStreamWriter.Write((sendBuffer[bufferIndex++] + 1).ToString() + Environment.NewLine);
            resultStreamWriter.Write("Rat ID: " + ratID.Text + Environment.NewLine);
            resultStreamWriter.Write(Environment.NewLine + "Arm enter sequence:" + Environment.NewLine);              
            trainingState.Text = "Training";
            resultFilePath.ForeColor = Color.Black;
            resultFilePath.Text = resultFileDialog.FileName;
            startButton.BackColor = Color.Orange;
            arm_Info.netState = connectionStatus.CONNECTED_KNOCK_DOOR;
            networkTimer.Enabled = true;
            return;
        }

        static public long getCurrentTimestamp()
        {
            return (long)(DateTime.UtcNow - new DateTime(1970, 1, 1, 0, 0, 0, 0)).TotalSeconds;
        }

        private void timerTimeElapsed_Tick(object sender, EventArgs e) /* max counting time should under 1 hour */
        {
            timeElapsed.Text = (timerCount / 60).ToString() + ":" + (timerCount % 60).ToString();
            timerCount++;
        }

        private void checkBoxArmLoc0_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter_1(object sender, EventArgs e)
        {

        }

        private void stopbutton_Click(object sender, EventArgs e)
        {
            timerTimeElapsed.Enabled = false;
            arm_Info.netState = connectionStatus.END_TRAINING_IN_PROGRESS;
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            ratID.Text = "";
            longTerm1.Text = "0";
            longTerm2.Text = "0";
            longTerm3.Text = "0";
            longTerm4.Text = "0";
            longTerm5.Text = "0";
            longTerm6.Text = "0";
            longTerm7.Text = "0";
            longTerm8.Text = "0";
            shortTerm1.Text = "0";
            shortTerm2.Text = "0";
            shortTerm3.Text = "0";
            shortTerm4.Text = "0";
            shortTerm5.Text = "0";
            shortTerm6.Text = "0";
            shortTerm7.Text = "0";
            shortTerm8.Text = "0";
            foodAte.Text = "0";
            totalLongTerm.Text = "0";
            totalShortTerm.Text = "0";

        }

        private void mazeState_TextChanged(object sender, EventArgs e)
        {

        }
    }
    static class globalBuffer
    {
        public static byte[] g_recvBuffer = new byte[64];
        public static Socket g_recvSocketfd;
        public static bool g_isDataReceive;
        public static bool g_dataNeedProcess;
        public static bool g_isThreadWorking;

    }
    class Work
    {
        static IPEndPoint remoteIpInfo = new IPEndPoint(IPAddress.Parse("192.168.4.1"), 3232);
        static EndPoint Remote;
        public static void doRemoteIPcast()
        {
            Remote = (EndPoint)remoteIpInfo;
        }
        public static void taskRecvThread()
        {
            //IPEndPoint serverIpInfo = new IPEndPoint(IPAddress.Any, 60138);
            Array.Clear(globalBuffer.g_recvBuffer, 0, globalBuffer.g_recvBuffer.Length);
            doRemoteIPcast();
            //globalBuffer.g_recvSocketfd = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
            //globalBuffer.g_recvSocketfd.Bind(serverIpInfo);
            //globalBuffer.g_recvSocketfd.ReceiveTimeout = 1000;
            while (true)
            {
                if (!globalBuffer.g_isDataReceive && globalBuffer.g_isThreadWorking)
                {
                    try
                    {
                        globalBuffer.g_recvSocketfd.ReceiveFrom(globalBuffer.g_recvBuffer, 0, 64, SocketFlags.None, ref Remote);
                    }
                    catch
                    {

                    }
                    if (globalBuffer.g_recvBuffer[0] != 0) /* data received */
                    {
                        globalBuffer.g_isDataReceive = true; /* this var is buggy, it is suppose to break data parse when no data receive */
                        globalBuffer.g_dataNeedProcess = true;
                    }
                        
                }                
                Thread.Sleep(1);
            }
        }

    }
}
