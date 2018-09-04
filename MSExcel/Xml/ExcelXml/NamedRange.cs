namespace Nistec.Imex.ExcelXml
{
    using System;

    internal class NamedRange
    {
        internal string Name;
        internal Nistec.Imex.ExcelXml.Range Range;
        internal Nistec.Imex.ExcelXml.Worksheet Worksheet;

        internal NamedRange(Nistec.Imex.ExcelXml.Range range, string name, Nistec.Imex.ExcelXml.Worksheet ws)
        {
            if (range == null)
            {
                throw new ArgumentNullException("range");
            }
            if (string.IsNullOrEmpty(name))
            {
                throw new ArgumentNullException("name");
            }
            this.Worksheet = ws;
            this.Range = range;
            this.Name = name;
        }
    }
}

