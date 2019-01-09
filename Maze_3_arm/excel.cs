using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClosedXML.Excel;
using System.ComponentModel;
using System.Reflection;

namespace GenXLSX
{

    public class XSLXHelper
    {
        /// <summary>
        /// 產生 excel
        /// </summary>
        /// <typeparam name="T">傳入的物件型別</typeparam>
        /// <param name="data">物件資料集</param>
        /// <returns></returns>
        
        public String ratID;
        public XLWorkbook workbook;
        public ushort sheetIndex;
        public XSLXHelper()
        {
            workbook = new XLWorkbook();
            sheetIndex = 1;
        }
        public XLWorkbook Export<T>(List<T> data)
        {
            //加入 excel 工作表名為 `Report`
            int colIdx = 1;
            int rowIdx = 2;
            IXLWorksheet oldSheet;
            if (ratID == "")
                ratID = "Unknown";
            bool isSheetExist = workbook.Worksheets.TryGetWorksheet(ratID, out oldSheet); // if them complain with this feature, tell them shortkey ctrl+PageDown(Up)
            if (isSheetExist)
            {
                //使用 reflection 將物件屬性取出當作工作表欄位名稱
                foreach (var item in typeof(T).GetProperties())
                {
                    #region - 可以使用 DescriptionAttribute 設定，找不到 DescriptionAttribute 時改用屬性名稱 -
                    //可以使用 DescriptionAttribute 設定，找不到 DescriptionAttribute 時改用屬性名稱
                    //DescriptionAttribute description = item.GetCustomAttribute(typeof(DescriptionAttribute)) as DescriptionAttribute;
                    //if (description != null)
                    //{
                    //    sheet.Cell(1, colIdx++).Value=description.Description;
                    //    continue;
                    //}
                    //sheet.Cell(1, colIdx++).Value = item.Name;
                    #endregion
                    #region - 直接使用物件屬性名稱 -
                    //或是直接使用物件屬性名稱
                    oldSheet.Cell(1, colIdx++).Value = item.Name;
                    oldSheet.Cell(1, colIdx++).IsEmpty();
                    #endregion

                }
                //資料起始列位置
                foreach (var item in data)
                {
                    //每筆資料欄位起始位置
                    int conlumnIndex = 1;
                    while (!oldSheet.Cell(rowIdx, conlumnIndex).IsEmpty())
                        rowIdx++;
                    foreach (var jtem in item.GetType().GetProperties())
                    {
                        //將資料內容加上 "'" 避免受到 excel 預設格式影響，並依 row 及 column 填入                        
                        oldSheet.Cell(rowIdx, conlumnIndex).Value = string.Concat("'", Convert.ToString(jtem.GetValue(item, null)));
                        conlumnIndex += 2;
                    }
                    rowIdx++;
                }
            }
            else
            {
                var sheet = workbook.Worksheets.Add(ratID, sheetIndex++); // if them complain with this feature, tell them shortkey ctrl+PageDown(Up)
                                                                          //使用 reflection 將物件屬性取出當作工作表欄位名稱
                foreach (var item in typeof(T).GetProperties())
                {
                    #region - 可以使用 DescriptionAttribute 設定，找不到 DescriptionAttribute 時改用屬性名稱 -
                    //可以使用 DescriptionAttribute 設定，找不到 DescriptionAttribute 時改用屬性名稱
                    //DescriptionAttribute description = item.GetCustomAttribute(typeof(DescriptionAttribute)) as DescriptionAttribute;
                    //if (description != null)
                    //{
                    //    sheet.Cell(1, colIdx++).Value=description.Description;
                    //    continue;
                    //}
                    //sheet.Cell(1, colIdx++).Value = item.Name;
                    #endregion
                    #region - 直接使用物件屬性名稱 -
                    //或是直接使用物件屬性名稱
                    sheet.Cell(1, colIdx++).Value = item.Name;
                    sheet.Cell(1, colIdx++).IsEmpty();
                    #endregion

                }
                //資料起始列位置
                foreach (var item in data)
                {
                    //每筆資料欄位起始位置
                    int conlumnIndex = 1;
                    while (!sheet.Cell(rowIdx, conlumnIndex).IsEmpty())
                        rowIdx++;
                    foreach (var jtem in item.GetType().GetProperties())
                    {
                        //將資料內容加上 "'" 避免受到 excel 預設格式影響，並依 row 及 column 填入
                        sheet.Cell(rowIdx, conlumnIndex).Value = string.Concat("'", Convert.ToString(jtem.GetValue(item, null)));
                        conlumnIndex += 2;
                    }
                    rowIdx++;
                }
            }

            
            return workbook;
        }
    }
}
