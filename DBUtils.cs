using MySql.Data.MySqlClient;

namespace LearnForms1
{
    internal class DBUtils
    {

        public static MySqlConnection GetDBConnection()
        {
            string host = "127.0.0.1";
            int port = 3306;
            string database = "securities_transactions";
            string username = "root";
            string password = "rootPass123";

            return DBMySQLUtils.GetDBConnection(host, port, database, username, password);
        }

    }
}
