using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
//using Nistec.Win;

namespace Nistec.Imex.Data
{
    public static class AdoImport
    {

        public static DataTable Import(ImportType exType, string fileName, bool firstRowHeader)
        {
            switch (exType)
            {
                case ImportType.Excel:
                    return Nistec.Imex.MSExcel.Bin2003.ExcelReader.Import(fileName, firstRowHeader);
                case ImportType.ExcelXml:
                    return Nistec.Imex.ExcelXml.Workbook.Import(fileName, firstRowHeader,0,0);
                case ImportType.Csv:
                    return Nistec.Imex.Csv.CsvReader.Import(fileName, firstRowHeader);
                case ImportType.Xml:
                    return Nistec.Imex.Xml.XmlReader.Import(fileName, System.IO.Path.GetFileNameWithoutExtension(fileName).Replace(" ",""));
                case ImportType.OleDb:
                    return Nistec.Imex.MSExcel.OleDb.ExcelReader.ReadFirstWorksheet(fileName, firstRowHeader,65000,1);
                    //if (ds == null || ds.Tables.Count == 0)
                    //    return null;
                    //return ds.Tables[0];
                default:
                    return Nistec.Imex.MSExcel.Bin2003.ExcelReader.Import(fileName, firstRowHeader);
            }
        }
        //~csv
        //public static string GetFileImportName()
        //{
        //    string filter = "XLS files (*.xls)|*.xls|CSV files (*.csv)|*.csv|XML files (*.xml)|*.xml";//|HTML files (*.htm)|*.htm";
        //    return CommonDlg.FileDialog(filter);
        //}

        public static DataTable Import(string fileName)
        {
            //string fileName = GetFileImportName();
            if (fileName != "")
            {
                if (fileName.ToLower().EndsWith("csv"))
                {
                    return Import(ImportType.Csv, fileName, false);
                  }
                else if (fileName.ToLower().EndsWith("xls"))
                {
                    return Import(ImportType.Excel, fileName, false);
                }
                else if (fileName.ToLower().EndsWith("xml"))
                {
                    return Import(ImportType.Xml, fileName, false);
                }
            }
            return null;
        }

    }
}
