namespace Nistec.Imex.MSExcel.Xml
{
    using Nistec.Imex;
    using System;
    using System.Collections;
    using System.Data;
    using System.Data.OleDb;
    using System.Text;

    public static class ExcelHelper
    {

        public static string[] GetGetWorksheets(ExcelReadProperties properties)
        {

           return ExcelXml.Workbook.GetWorksheets(properties.Workbook);
            
        }


    }
}

