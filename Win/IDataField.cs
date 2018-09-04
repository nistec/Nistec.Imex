using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Nistec.Imex.Data
{
    public interface IDataField
    {
        string Caption { get; set; }
        string ColumnName { get; set; }
        FieldType FieldType { get; }
        int Ordinal { get; set; }

        string ToString();
    }
}
