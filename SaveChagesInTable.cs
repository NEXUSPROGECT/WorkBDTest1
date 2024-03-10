using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;


namespace LearnForms1
{
    internal class SaveChagesInTable
    {
        public static void SaveChagenges(DataSet dataSet, String nameTable) 
        {
            using (MySqlConnection connection = DBUtils.GetDBConnection())
            {
                try 
                {
                    connection.Open();
                    MySqlDataAdapter adapter1 = new MySqlDataAdapter($"SELECT * FROM {nameTable}", connection);
                    MySqlCommandBuilder builder1 = new MySqlCommandBuilder(adapter1);
                    adapter1.Update(dataSet, nameTable);
                    connection.Close();
                }
                catch(Exception e) 
                {
                    MessageBox.Show(e.Message);
                    return;
                }                                  
            }
        }
    }
}
