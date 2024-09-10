using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfAppMusic;

    MySqlConnection mySqlConnection;
    MySqlConnectionStringBuilder sb =
        new MySqlConnectionStringBuilder();
    sb.Server = "192.168.200.13";
    sb.UserID = "student";
    sb.Password = "student";
    sb.Database = "database_Music_1135_new_free_bez_sms";
    sb.CharacterSet = "utf8mb4";
    sb.ConnectionTimeout = 5;
    //Console.WriteLine(sb.ToString());
    mySqlConnection = new MySqlConnection(sb.ToString());
    
    try
    {
        mySqlConnection.Open();
    }
    catch (MySqlException ex)
    {
        Console.WriteLine($"{ex.Number}: {ex.Message}");
        return;
    }
    
    MysqlTools.SetConnection(mySqlConnection);
    
