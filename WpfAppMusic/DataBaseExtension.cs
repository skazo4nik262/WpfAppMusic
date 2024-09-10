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
        public static List<Music> GetMusic(this DataBase database)
        {
            return MysqlTools.SimpleSelectFromTable<Music>();
        }
    }
}
