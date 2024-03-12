using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnForms1
{
    internal class IndicateConnectBD
    {
        public static string examConnect() 
        {
                using(MySqlConnection connection = DBUtils.GetDBConnection() ) 
                {
                    try 
                    { 
                        connection.Open();
                        connection.Close();
                        return "CONNECTED";
                    }
                    catch { return "NOT CONNECTED"; } 
                }
        }
    }
}
