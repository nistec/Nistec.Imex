namespace Nistec.Imex.Data
{
    using Nistec.Imex;
    using System;
    using System.Data;
    using System.Data.OleDb;
    using System.Drawing;
    using System.Reflection;
    //using System.Windows.Forms;
    using System.IO;

    public class AdoWriter : IAdoWriter
    {
        IAdoWriter _writer;

        public AdoWriter(WriterType type, AdoProperties properties)
        {
            switch (type)
            {
                case WriterType.ExcelOleDb:
                    _writer = new Nistec.Imex.MSExcel.OleDb.ExcelWriter(properties as MSExcel.ExcelWriteProperties);
                    break;
                case WriterType.ExcelXml:
                    _writer = new Nistec.Imex.MSExcel.Xml.ExcelWriter(properties as MSExcel.ExcelWriteProperties);
                    break;
                case WriterType.Csv:
                    _writer = new Nistec.Imex.Csv.CsvWriter(properties as Csv.CsvWriteProperties);
                    break;
                case WriterType.Html:
                    _writer = new Nistec.Imex.Html.HtmlWriter(properties as Html.HtmlWriteProperties);
                    break;
                case WriterType.Xml:
                    _writer = new Nistec.Imex.Xml.XmlWriter(properties as Xml.XmlWriteProperties);
                    break;
                case WriterType.Pdf:
                    throw new Exception("ExportType.Pdf not supported");//
                    //_writer = new Nistec.Imex.Pdf.PdfWriter(properties as Pdf.PdfWriteProperties);
                    break;
                default:
                    throw new ArgumentException("WriterType not supported");
            }
            //_writer.Properties = properties.Clone();// new AdoWriteProperties();
            //base.Output=new AdoOutput("Records To Write", "Records successfully written to the configured MS Ado.");//, true);
        }

        public bool ExecuteBatch(uint batchSize)
        {
            return _writer.ExecuteBatch(batchSize);
        }

        public bool Execute()
        {
                return _writer.Execute();
        }
        public void ExecuteBegin(uint totalObjects)
        {
            _writer.ExecuteBegin(totalObjects);
        }

        public uint ExecuteCommit()
        {
            return _writer.ExecuteCommit();
        }

        public void CancelExecute(string message)
        {
           _writer.CancelExecute(message);
        }

        public AdoOutput Output
        {
            get{return _writer.Output;}
        }

        public AdoProperties Properties
        {
            get { return _writer.Properties; }
            set { _writer.Properties = value; }
        }


        //public override AdoTable GetSchema()
        //{
        //    AdoWriteProperties properties = this.Properties as AdoWriteProperties;
        //    return _writer.Properties. properties.DataSource;
        //}

 
    }
}

