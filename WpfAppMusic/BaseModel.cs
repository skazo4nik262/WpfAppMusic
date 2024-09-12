using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public abstract class BaseModel
{
    [MysqlColumn("id")]
    public int ID { get; set; }
}
