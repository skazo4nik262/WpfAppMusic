using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfAppMusic
{
    [MysqlTable("Music")]
    public class Music : BaseModel
    {
        [MysqlColumn("ID")]
        public int ID { get; set; }
        [MysqlColumn("Title")]
        public string Title { get; set; }
        [MysqlColumn("Singer_ID")]
        public int Artist_ID { get; set; }
        [MysqlColumn("Album_ID")]
        public int Album_ID { get; set; }
    }
}
