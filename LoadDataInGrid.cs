using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;


namespace LearnForms1
{
    internal class LoadDataInGrid
    {
        public static DataSet exstractData(DataGridView dataGridView1, String nameTable, Label labelTable) 
        {
            DataSet dataSet = new DataSet();
            try
            {
                using (MySqlConnection connection = DBUtils.GetDBConnection())
                {
                    connection.Open();
                    MySqlDataAdapter adapter1 = new MySqlDataAdapter($"SELECT * FROM {nameTable}", connection);
                    adapter1.Fill(dataSet, nameTable);
                    connection.Close();
                }
                labelTable.Text = nameTable;
            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message);
            }
            
            dataGridView1.DataSource = dataSet.Tables[nameTable];
            if (dataSet == null)
            {
                MessageBox.Show("Your table not have id data");
            }
            return dataSet;
        }
    }
}
