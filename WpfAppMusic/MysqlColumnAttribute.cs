using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    public class MysqlColumnAttribute : Attribute
    {
        public string ColumnName { get; set; }

        public MysqlColumnAttribute(string column)
        {
            ColumnName = column;
        }
    }
