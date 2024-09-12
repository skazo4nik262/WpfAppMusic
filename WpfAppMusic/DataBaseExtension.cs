using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace WpfAppMusic
{
    public static class DataBaseExtension
    {
        public static List<Singer> GetSinger(this DataBase database)
        {
            return MysqlTools.SimpleSelectFromTable<Singer>();
        }
        public static Singer GetSingerByID(this DataBase database, int id)
        {
            return MysqlTools.SelectRowFromTable<Singer>(id);
        }
        public static Music GetMusicByID(this DataBase database, int id)
        {
            return MysqlTools.SelectRowFromTable<Music>(id);
        }
    }
}
