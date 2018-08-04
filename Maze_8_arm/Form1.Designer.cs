namespace Maze_8_arm
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBoxFood = new System.Windows.Forms.GroupBox();
            this.checkBoxArmLoc7 = new System.Windows.Forms.CheckBox();
            this.checkBoxArmLoc3 = new System.Windows.Forms.CheckBox();
            this.checkBoxArmLoc0 = new System.Windows.Forms.CheckBox();
            this.checkBoxArmLoc4 = new System.Windows.Forms.CheckBox();
            this.checkBoxArmLoc1 = new System.Windows.Forms.CheckBox();
            this.checkBoxArmLoc5 = new System.Windows.Forms.CheckBox();
            this.checkBoxArmLoc2 = new System.Windows.Forms.CheckBox();
            this.checkBoxArmLoc6 = new System.Windows.Forms.CheckBox();
            this.mazeState = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.timeElapsed = new System.Windows.Forms.TextBox();
            this.totalShortTerm = new System.Windows.Forms.TextBox();
            this.totalLongTerm = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.foodAte = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.longTerm2 = new System.Windows.Forms.TextBox();
            this.longTerm3 = new System.Windows.Forms.TextBox();
            this.longTerm4 = new System.Windows.Forms.TextBox();
            this.longTerm5 = new System.Windows.Forms.TextBox();
            this.longTerm6 = new System.Windows.Forms.TextBox();
            this.longTerm7 = new System.Windows.Forms.TextBox();
            this.longTerm8 = new System.Windows.Forms.TextBox();
            this.shortTerm1 = new System.Windows.Forms.TextBox();
            this.shortTerm2 = new System.Windows.Forms.TextBox();
            this.shortTerm3 = new System.Windows.Forms.TextBox();
            this.shortTerm4 = new System.Windows.Forms.TextBox();
            this.shortTerm5 = new System.Windows.Forms.TextBox();
            this.shortTerm8 = new System.Windows.Forms.TextBox();
            this.shortTerm7 = new System.Windows.Forms.TextBox();
            this.shortTerm6 = new System.Windows.Forms.TextBox();
            this.longTerm1 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.connectionState = new System.Windows.Forms.TextBox();
            this.trainingState = new System.Windows.Forms.TextBox();
            this.networkTimer = new System.Windows.Forms.Timer(this.components);
            this.label18 = new System.Windows.Forms.Label();
            this.errorBox = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.resultFilePath = new System.Windows.Forms.TextBox();
            this.pathSelectButton = new System.Windows.Forms.Button();
            this.resultFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.startButton = new System.Windows.Forms.Button();
            this.timerTimeElapsed = new System.Windows.Forms.Timer(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBoxFood.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("新細明體", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(678, 396);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(482, 52);
            this.label1.TabIndex = 0;
            this.label1.Text = "Training elapsed time :";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(130, 126);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 32);
            this.label2.TabIndex = 2;
            this.label2.Text = "Arm 1 :";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBoxFood);
            this.groupBox1.Controls.Add(this.mazeState);
            this.groupBox1.Controls.Add(this.label19);
            this.groupBox1.Controls.Add(this.timeElapsed);
            this.groupBox1.Controls.Add(this.totalShortTerm);
            this.groupBox1.Controls.Add(this.totalLongTerm);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.foodAte);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.longTerm2);
            this.groupBox1.Controls.Add(this.longTerm3);
            this.groupBox1.Controls.Add(this.longTerm4);
            this.groupBox1.Controls.Add(this.longTerm5);
            this.groupBox1.Controls.Add(this.longTerm6);
            this.groupBox1.Controls.Add(this.longTerm7);
            this.groupBox1.Controls.Add(this.longTerm8);
            this.groupBox1.Controls.Add(this.shortTerm1);
            this.groupBox1.Controls.Add(this.shortTerm2);
            this.groupBox1.Controls.Add(this.shortTerm3);
            this.groupBox1.Controls.Add(this.shortTerm4);
            this.groupBox1.Controls.Add(this.shortTerm5);
            this.groupBox1.Controls.Add(this.shortTerm8);
            this.groupBox1.Controls.Add(this.shortTerm7);
            this.groupBox1.Controls.Add(this.shortTerm6);
            this.groupBox1.Controls.Add(this.longTerm1);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.groupBox1.Location = new System.Drawing.Point(13, 146);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(1192, 762);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Statistics";
            // 
            // groupBoxFood
            // 
            this.groupBoxFood.Controls.Add(this.checkBoxArmLoc7);
            this.groupBoxFood.Controls.Add(this.checkBoxArmLoc3);
            this.groupBoxFood.Controls.Add(this.checkBoxArmLoc0);
            this.groupBoxFood.Controls.Add(this.checkBoxArmLoc4);
            this.groupBoxFood.Controls.Add(this.checkBoxArmLoc1);
            this.groupBoxFood.Controls.Add(this.checkBoxArmLoc5);
            this.groupBoxFood.Controls.Add(this.checkBoxArmLoc2);
            this.groupBoxFood.Controls.Add(this.checkBoxArmLoc6);
            this.groupBoxFood.Location = new System.Drawing.Point(26, 76);
            this.groupBoxFood.Name = "groupBoxFood";
            this.groupBoxFood.Size = new System.Drawing.Size(97, 618);
            this.groupBoxFood.TabIndex = 45;
            this.groupBoxFood.TabStop = false;
            this.groupBoxFood.Text = "Food";
            this.groupBoxFood.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // checkBoxArmLoc7
            // 
            this.checkBoxArmLoc7.AutoSize = true;
            this.checkBoxArmLoc7.Location = new System.Drawing.Point(31, 528);
            this.checkBoxArmLoc7.Name = "checkBoxArmLoc7";
            this.checkBoxArmLoc7.Size = new System.Drawing.Size(22, 21);
            this.checkBoxArmLoc7.TabIndex = 41;
            this.checkBoxArmLoc7.UseVisualStyleBackColor = true;
            // 
            // checkBoxArmLoc3
            // 
            this.checkBoxArmLoc3.AutoSize = true;
            this.checkBoxArmLoc3.Location = new System.Drawing.Point(30, 258);
            this.checkBoxArmLoc3.Name = "checkBoxArmLoc3";
            this.checkBoxArmLoc3.Size = new System.Drawing.Size(22, 21);
            this.checkBoxArmLoc3.TabIndex = 45;
            this.checkBoxArmLoc3.UseVisualStyleBackColor = true;
            // 
            // checkBoxArmLoc0
            // 
            this.checkBoxArmLoc0.AutoSize = true;
            this.checkBoxArmLoc0.Location = new System.Drawing.Point(30, 57);
            this.checkBoxArmLoc0.Name = "checkBoxArmLoc0";
            this.checkBoxArmLoc0.Size = new System.Drawing.Size(22, 21);
            this.checkBoxArmLoc0.TabIndex = 37;
            this.checkBoxArmLoc0.UseVisualStyleBackColor = true;
            this.checkBoxArmLoc0.CheckedChanged += new System.EventHandler(this.checkBoxArmLoc0_CheckedChanged);
            // 
            // checkBoxArmLoc4
            // 
            this.checkBoxArmLoc4.AutoSize = true;
            this.checkBoxArmLoc4.Location = new System.Drawing.Point(31, 326);
            this.checkBoxArmLoc4.Name = "checkBoxArmLoc4";
            this.checkBoxArmLoc4.Size = new System.Drawing.Size(22, 21);
            this.checkBoxArmLoc4.TabIndex = 44;
            this.checkBoxArmLoc4.UseVisualStyleBackColor = true;
            // 
            // checkBoxArmLoc1
            // 
            this.checkBoxArmLoc1.AutoSize = true;
            this.checkBoxArmLoc1.Location = new System.Drawing.Point(30, 124);
            this.checkBoxArmLoc1.Name = "checkBoxArmLoc1";
            this.checkBoxArmLoc1.Size = new System.Drawing.Size(22, 21);
            this.checkBoxArmLoc1.TabIndex = 39;
            this.checkBoxArmLoc1.UseVisualStyleBackColor = true;
            // 
            // checkBoxArmLoc5
            // 
            this.checkBoxArmLoc5.AutoSize = true;
            this.checkBoxArmLoc5.Location = new System.Drawing.Point(30, 395);
            this.checkBoxArmLoc5.Name = "checkBoxArmLoc5";
            this.checkBoxArmLoc5.Size = new System.Drawing.Size(22, 21);
            this.checkBoxArmLoc5.TabIndex = 43;
            this.checkBoxArmLoc5.UseVisualStyleBackColor = true;
            // 
            // checkBoxArmLoc2
            // 
            this.checkBoxArmLoc2.AutoSize = true;
            this.checkBoxArmLoc2.Location = new System.Drawing.Point(30, 191);
            this.checkBoxArmLoc2.Name = "checkBoxArmLoc2";
            this.checkBoxArmLoc2.Size = new System.Drawing.Size(22, 21);
            this.checkBoxArmLoc2.TabIndex = 40;
            this.checkBoxArmLoc2.UseVisualStyleBackColor = true;
            // 
            // checkBoxArmLoc6
            // 
            this.checkBoxArmLoc6.AutoSize = true;
            this.checkBoxArmLoc6.Location = new System.Drawing.Point(31, 463);
            this.checkBoxArmLoc6.Name = "checkBoxArmLoc6";
            this.checkBoxArmLoc6.Size = new System.Drawing.Size(22, 21);
            this.checkBoxArmLoc6.TabIndex = 42;
            this.checkBoxArmLoc6.UseVisualStyleBackColor = true;
            // 
            // mazeState
            // 
            this.mazeState.Enabled = false;
            this.mazeState.Location = new System.Drawing.Point(926, 298);
            this.mazeState.Margin = new System.Windows.Forms.Padding(4);
            this.mazeState.Name = "mazeState";
            this.mazeState.Size = new System.Drawing.Size(228, 45);
            this.mazeState.TabIndex = 36;
            this.mazeState.Text = "Wait for rat";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(680, 303);
            this.label19.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(173, 32);
            this.label19.TabIndex = 35;
            this.label19.Text = "Maze status :";
            // 
            // timeElapsed
            // 
            this.timeElapsed.Enabled = false;
            this.timeElapsed.Font = new System.Drawing.Font("新細明體", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.timeElapsed.Location = new System.Drawing.Point(684, 464);
            this.timeElapsed.Margin = new System.Windows.Forms.Padding(4);
            this.timeElapsed.Name = "timeElapsed";
            this.timeElapsed.Size = new System.Drawing.Size(470, 180);
            this.timeElapsed.TabIndex = 34;
            // 
            // totalShortTerm
            // 
            this.totalShortTerm.Enabled = false;
            this.totalShortTerm.Location = new System.Drawing.Point(926, 238);
            this.totalShortTerm.Margin = new System.Windows.Forms.Padding(4);
            this.totalShortTerm.Name = "totalShortTerm";
            this.totalShortTerm.Size = new System.Drawing.Size(127, 45);
            this.totalShortTerm.TabIndex = 33;
            this.totalShortTerm.Text = "0";
            // 
            // totalLongTerm
            // 
            this.totalLongTerm.Enabled = false;
            this.totalLongTerm.Location = new System.Drawing.Point(926, 165);
            this.totalLongTerm.Margin = new System.Windows.Forms.Padding(4);
            this.totalLongTerm.Name = "totalLongTerm";
            this.totalLongTerm.Size = new System.Drawing.Size(127, 45);
            this.totalLongTerm.TabIndex = 32;
            this.totalLongTerm.Text = "0";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(681, 243);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(231, 32);
            this.label14.TabIndex = 31;
            this.label14.Text = "Total short term : ";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(680, 170);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(224, 32);
            this.label13.TabIndex = 30;
            this.label13.Text = "Total long term : ";
            // 
            // foodAte
            // 
            this.foodAte.Enabled = false;
            this.foodAte.Location = new System.Drawing.Point(926, 81);
            this.foodAte.Margin = new System.Windows.Forms.Padding(4);
            this.foodAte.Name = "foodAte";
            this.foodAte.Size = new System.Drawing.Size(127, 45);
            this.foodAte.TabIndex = 29;
            this.foodAte.Text = "0";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(681, 86);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(135, 32);
            this.label12.TabIndex = 28;
            this.label12.Text = "Food ate :";
            // 
            // longTerm2
            // 
            this.longTerm2.Enabled = false;
            this.longTerm2.Location = new System.Drawing.Point(284, 190);
            this.longTerm2.Margin = new System.Windows.Forms.Padding(4);
            this.longTerm2.Name = "longTerm2";
            this.longTerm2.Size = new System.Drawing.Size(127, 45);
            this.longTerm2.TabIndex = 27;
            this.longTerm2.Text = "0";
            // 
            // longTerm3
            // 
            this.longTerm3.Enabled = false;
            this.longTerm3.Location = new System.Drawing.Point(284, 257);
            this.longTerm3.Margin = new System.Windows.Forms.Padding(4);
            this.longTerm3.Name = "longTerm3";
            this.longTerm3.Size = new System.Drawing.Size(127, 45);
            this.longTerm3.TabIndex = 26;
            this.longTerm3.Text = "0";
            // 
            // longTerm4
            // 
            this.longTerm4.Enabled = false;
            this.longTerm4.Location = new System.Drawing.Point(284, 324);
            this.longTerm4.Margin = new System.Windows.Forms.Padding(4);
            this.longTerm4.Name = "longTerm4";
            this.longTerm4.Size = new System.Drawing.Size(127, 45);
            this.longTerm4.TabIndex = 25;
            this.longTerm4.Text = "0";
            // 
            // longTerm5
            // 
            this.longTerm5.Enabled = false;
            this.longTerm5.Location = new System.Drawing.Point(284, 392);
            this.longTerm5.Margin = new System.Windows.Forms.Padding(4);
            this.longTerm5.Name = "longTerm5";
            this.longTerm5.Size = new System.Drawing.Size(127, 45);
            this.longTerm5.TabIndex = 24;
            this.longTerm5.Text = "0";
            // 
            // longTerm6
            // 
            this.longTerm6.Enabled = false;
            this.longTerm6.Location = new System.Drawing.Point(284, 460);
            this.longTerm6.Margin = new System.Windows.Forms.Padding(4);
            this.longTerm6.Name = "longTerm6";
            this.longTerm6.Size = new System.Drawing.Size(127, 45);
            this.longTerm6.TabIndex = 23;
            this.longTerm6.Text = "0";
            // 
            // longTerm7
            // 
            this.longTerm7.Enabled = false;
            this.longTerm7.Location = new System.Drawing.Point(284, 527);
            this.longTerm7.Margin = new System.Windows.Forms.Padding(4);
            this.longTerm7.Name = "longTerm7";
            this.longTerm7.Size = new System.Drawing.Size(127, 45);
            this.longTerm7.TabIndex = 22;
            this.longTerm7.Text = "0";
            // 
            // longTerm8
            // 
            this.longTerm8.Enabled = false;
            this.longTerm8.Location = new System.Drawing.Point(284, 594);
            this.longTerm8.Margin = new System.Windows.Forms.Padding(4);
            this.longTerm8.Name = "longTerm8";
            this.longTerm8.Size = new System.Drawing.Size(127, 45);
            this.longTerm8.TabIndex = 21;
            this.longTerm8.Text = "0";
            // 
            // shortTerm1
            // 
            this.shortTerm1.Enabled = false;
            this.shortTerm1.Location = new System.Drawing.Point(488, 122);
            this.shortTerm1.Margin = new System.Windows.Forms.Padding(4);
            this.shortTerm1.Name = "shortTerm1";
            this.shortTerm1.Size = new System.Drawing.Size(127, 45);
            this.shortTerm1.TabIndex = 20;
            this.shortTerm1.Text = "0";
            // 
            // shortTerm2
            // 
            this.shortTerm2.Enabled = false;
            this.shortTerm2.Location = new System.Drawing.Point(488, 190);
            this.shortTerm2.Margin = new System.Windows.Forms.Padding(4);
            this.shortTerm2.Name = "shortTerm2";
            this.shortTerm2.Size = new System.Drawing.Size(127, 45);
            this.shortTerm2.TabIndex = 19;
            this.shortTerm2.Text = "0";
            // 
            // shortTerm3
            // 
            this.shortTerm3.Enabled = false;
            this.shortTerm3.Location = new System.Drawing.Point(488, 257);
            this.shortTerm3.Margin = new System.Windows.Forms.Padding(4);
            this.shortTerm3.Name = "shortTerm3";
            this.shortTerm3.Size = new System.Drawing.Size(127, 45);
            this.shortTerm3.TabIndex = 18;
            this.shortTerm3.Text = "0";
            // 
            // shortTerm4
            // 
            this.shortTerm4.Enabled = false;
            this.shortTerm4.Location = new System.Drawing.Point(488, 324);
            this.shortTerm4.Margin = new System.Windows.Forms.Padding(4);
            this.shortTerm4.Name = "shortTerm4";
            this.shortTerm4.Size = new System.Drawing.Size(127, 45);
            this.shortTerm4.TabIndex = 17;
            this.shortTerm4.Text = "0";
            // 
            // shortTerm5
            // 
            this.shortTerm5.Enabled = false;
            this.shortTerm5.Location = new System.Drawing.Point(488, 392);
            this.shortTerm5.Margin = new System.Windows.Forms.Padding(4);
            this.shortTerm5.Name = "shortTerm5";
            this.shortTerm5.Size = new System.Drawing.Size(127, 45);
            this.shortTerm5.TabIndex = 16;
            this.shortTerm5.Text = "0";
            // 
            // shortTerm8
            // 
            this.shortTerm8.Enabled = false;
            this.shortTerm8.Location = new System.Drawing.Point(488, 594);
            this.shortTerm8.Margin = new System.Windows.Forms.Padding(4);
            this.shortTerm8.Name = "shortTerm8";
            this.shortTerm8.Size = new System.Drawing.Size(127, 45);
            this.shortTerm8.TabIndex = 15;
            this.shortTerm8.Text = "0";
            // 
            // shortTerm7
            // 
            this.shortTerm7.Enabled = false;
            this.shortTerm7.Location = new System.Drawing.Point(488, 527);
            this.shortTerm7.Margin = new System.Windows.Forms.Padding(4);
            this.shortTerm7.Name = "shortTerm7";
            this.shortTerm7.Size = new System.Drawing.Size(127, 45);
            this.shortTerm7.TabIndex = 14;
            this.shortTerm7.Text = "0";
            // 
            // shortTerm6
            // 
            this.shortTerm6.Enabled = false;
            this.shortTerm6.Location = new System.Drawing.Point(488, 460);
            this.shortTerm6.Margin = new System.Windows.Forms.Padding(4);
            this.shortTerm6.Name = "shortTerm6";
            this.shortTerm6.Size = new System.Drawing.Size(127, 45);
            this.shortTerm6.TabIndex = 13;
            this.shortTerm6.Text = "0";
            // 
            // longTerm1
            // 
            this.longTerm1.Enabled = false;
            this.longTerm1.Location = new System.Drawing.Point(284, 122);
            this.longTerm1.Margin = new System.Windows.Forms.Padding(4);
            this.longTerm1.Name = "longTerm1";
            this.longTerm1.Size = new System.Drawing.Size(127, 45);
            this.longTerm1.TabIndex = 12;
            this.longTerm1.Text = "0";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(482, 76);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(142, 32);
            this.label11.TabIndex = 11;
            this.label11.Text = "Short term";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(278, 76);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(140, 32);
            this.label10.TabIndex = 10;
            this.label10.Text = "Long term";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label9.Location = new System.Drawing.Point(130, 262);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(109, 32);
            this.label9.TabIndex = 9;
            this.label9.Text = "Arm 3 :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label8.Location = new System.Drawing.Point(130, 329);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(109, 32);
            this.label8.TabIndex = 8;
            this.label8.Text = "Arm 4 :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label7.Location = new System.Drawing.Point(130, 396);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(109, 32);
            this.label7.TabIndex = 7;
            this.label7.Text = "Arm 5 :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label6.Location = new System.Drawing.Point(130, 464);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(109, 32);
            this.label6.TabIndex = 6;
            this.label6.Text = "Arm 6 :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label5.Location = new System.Drawing.Point(130, 532);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 32);
            this.label5.TabIndex = 5;
            this.label5.Text = "Arm 7 :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.Location = new System.Drawing.Point(130, 599);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 32);
            this.label4.TabIndex = 4;
            this.label4.Text = "Arm 8 :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(130, 194);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 32);
            this.label3.TabIndex = 3;
            this.label3.Text = "Arm 2 :";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("新細明體", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label15.Location = new System.Drawing.Point(68, 38);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(299, 41);
            this.label15.TabIndex = 34;
            this.label15.Text = "Connection state :";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("新細明體", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label16.Location = new System.Drawing.Point(896, 30);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(255, 41);
            this.label16.TabIndex = 35;
            this.label16.Text = "Training state :";
            // 
            // connectionState
            // 
            this.connectionState.Enabled = false;
            this.connectionState.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.connectionState.Location = new System.Drawing.Point(372, 33);
            this.connectionState.Margin = new System.Windows.Forms.Padding(4);
            this.connectionState.Name = "connectionState";
            this.connectionState.Size = new System.Drawing.Size(456, 45);
            this.connectionState.TabIndex = 36;
            this.connectionState.Text = "Unconnect";
            // 
            // trainingState
            // 
            this.trainingState.Enabled = false;
            this.trainingState.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.trainingState.Location = new System.Drawing.Point(1155, 33);
            this.trainingState.Margin = new System.Windows.Forms.Padding(4);
            this.trainingState.Multiline = true;
            this.trainingState.Name = "trainingState";
            this.trainingState.Size = new System.Drawing.Size(356, 102);
            this.trainingState.TabIndex = 37;
            this.trainingState.Text = "Preparing";
            // 
            // networkTimer
            // 
            this.networkTimer.Tick += new System.EventHandler(this.networkTimer_Tick);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label18.Location = new System.Drawing.Point(1214, 192);
            this.label18.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(178, 32);
            this.label18.TabIndex = 39;
            this.label18.Text = "Error output :";
            // 
            // errorBox
            // 
            this.errorBox.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.errorBox.Location = new System.Drawing.Point(1220, 248);
            this.errorBox.Margin = new System.Windows.Forms.Padding(4);
            this.errorBox.Multiline = true;
            this.errorBox.Name = "errorBox";
            this.errorBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.errorBox.Size = new System.Drawing.Size(660, 126);
            this.errorBox.TabIndex = 40;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label20.Location = new System.Drawing.Point(1214, 411);
            this.label20.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(192, 32);
            this.label20.TabIndex = 41;
            this.label20.Text = "Save location :";
            // 
            // resultFilePath
            // 
            this.resultFilePath.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.resultFilePath.Location = new System.Drawing.Point(1220, 466);
            this.resultFilePath.Margin = new System.Windows.Forms.Padding(4);
            this.resultFilePath.Name = "resultFilePath";
            this.resultFilePath.Size = new System.Drawing.Size(660, 42);
            this.resultFilePath.TabIndex = 42;
            // 
            // pathSelectButton
            // 
            this.pathSelectButton.Location = new System.Drawing.Point(1785, 530);
            this.pathSelectButton.Margin = new System.Windows.Forms.Padding(4);
            this.pathSelectButton.Name = "pathSelectButton";
            this.pathSelectButton.Size = new System.Drawing.Size(96, 48);
            this.pathSelectButton.TabIndex = 43;
            this.pathSelectButton.Text = "Open...";
            this.pathSelectButton.UseVisualStyleBackColor = true;
            this.pathSelectButton.Click += new System.EventHandler(this.pathSelectButton_Click);
            // 
            // resultFileDialog
            // 
            this.resultFileDialog.Filter = "文字檔 (*.txt)|*.txt|所有檔案 (*.*)|*.*";
            this.resultFileDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.resultFileDialog_FileOk);
            // 
            // startButton
            // 
            this.startButton.Font = new System.Drawing.Font("新細明體", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.startButton.Location = new System.Drawing.Point(1220, 614);
            this.startButton.Margin = new System.Windows.Forms.Padding(4);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(348, 190);
            this.startButton.TabIndex = 44;
            this.startButton.Text = "Start ";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // timerTimeElapsed
            // 
            this.timerTimeElapsed.Interval = 1000;
            this.timerTimeElapsed.Tick += new System.EventHandler(this.timerTimeElapsed_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1924, 951);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.pathSelectButton);
            this.Controls.Add(this.resultFilePath);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.errorBox);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.trainingState);
            this.Controls.Add(this.connectionState);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "8_arm Training module";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBoxFood.ResumeLayout(false);
            this.groupBoxFood.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox timeElapsed;
        private System.Windows.Forms.TextBox totalShortTerm;
        private System.Windows.Forms.TextBox totalLongTerm;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox foodAte;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox longTerm2;
        private System.Windows.Forms.TextBox longTerm3;
        private System.Windows.Forms.TextBox longTerm4;
        private System.Windows.Forms.TextBox longTerm5;
        private System.Windows.Forms.TextBox longTerm6;
        private System.Windows.Forms.TextBox longTerm7;
        private System.Windows.Forms.TextBox longTerm8;
        private System.Windows.Forms.TextBox shortTerm1;
        private System.Windows.Forms.TextBox shortTerm2;
        private System.Windows.Forms.TextBox shortTerm3;
        private System.Windows.Forms.TextBox shortTerm4;
        private System.Windows.Forms.TextBox shortTerm5;
        private System.Windows.Forms.TextBox shortTerm8;
        private System.Windows.Forms.TextBox shortTerm7;
        private System.Windows.Forms.TextBox shortTerm6;
        private System.Windows.Forms.TextBox longTerm1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox connectionState;
        private System.Windows.Forms.TextBox trainingState;
        private System.Windows.Forms.Timer networkTimer;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox errorBox;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox resultFilePath;
        private System.Windows.Forms.Button pathSelectButton;
        private System.Windows.Forms.SaveFileDialog resultFileDialog;
        private System.Windows.Forms.TextBox mazeState;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Timer timerTimeElapsed;
        private System.Windows.Forms.CheckBox checkBoxArmLoc0;
        private System.Windows.Forms.CheckBox checkBoxArmLoc3;
        private System.Windows.Forms.CheckBox checkBoxArmLoc4;
        private System.Windows.Forms.CheckBox checkBoxArmLoc5;
        private System.Windows.Forms.CheckBox checkBoxArmLoc6;
        private System.Windows.Forms.CheckBox checkBoxArmLoc7;
        private System.Windows.Forms.CheckBox checkBoxArmLoc2;
        private System.Windows.Forms.CheckBox checkBoxArmLoc1;
        private System.Windows.Forms.GroupBox groupBoxFood;
    }
}

