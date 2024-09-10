using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfAppMusic
{
    [MysqlTable("Singer")]
    public class Singer : BaseModel
    {
        [MysqlColumn("ID")]
        public int ID { get; set; }
        [MysqlColumn("FirstName")]
        public string FirstName { get; set; }
        [MysqlColumn("LastName")]
        public string LastName { get; set; }
    }
}
