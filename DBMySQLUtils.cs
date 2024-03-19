using System;
using MySql.Data.MySqlClient;

namespace LearnForms1
{
    internal class DBMySQLUtils
    {

        public static MySqlConnection
                 GetDBConnection(string host, string port, string database, string username, string password)
        {
            // Connection String.
            String connString = "Server=" + host + ";Database=" + database
                + ";port=" + port + ";User Id=" + username + ";password=" + password;

            MySqlConnection conn = new MySqlConnection(connString);

            return conn;
        }

    }
}
