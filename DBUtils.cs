using MySql.Data.MySqlClient;
using System.Collections;
using System.Windows.Forms;
using System.Xml;

namespace LearnForms1
{
    internal class DBUtils
    {

        
       

     
        public static MySqlConnection GetDBConnection()
        {
            var doc = new XmlDocument();
            doc.Load(@"C:\Users\Vusez\source\repos\LearnForms1\Files\db_connection_values.xml");
            var host = doc.SelectSingleNode("/values/host").InnerText;
            var port = doc.SelectSingleNode("/values/port").InnerText;
            var database = doc.SelectSingleNode("/values/database").InnerText;
            var username = doc.SelectSingleNode("/values/username").InnerText;
            var password = doc.SelectSingleNode("/values/password").InnerText;

            return DBMySQLUtils.GetDBConnection(host, port, database, username, password);
        }



        public static void Get()
        {

        }

    }
}
