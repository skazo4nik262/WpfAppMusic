using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfAppMusic
{
    [MysqlTable("Album")]
    public class ALbum : BaseModel
    {
        [MysqlColumn("ID")]
        public int ID { get; set; }
        [MysqlColumn("Name")]
        public string Name { get; set; }
    }
}
