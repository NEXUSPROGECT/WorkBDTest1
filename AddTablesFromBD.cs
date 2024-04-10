using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace LearnForms1
{
    internal class AddTablesFromBD : Formm1
    {
        public static void LoadTables(DataGridView datagGridView,MenuStrip menuStrip1  ,Label label)
        {
            using (MySqlConnection connection = DBUtils.GetDBConnection())
            {
                try
                {
                    connection.Open();
                    DataTable schema = connection.GetSchema("Tables");
                    foreach (DataRow row in schema.Rows)
                    {
                        string tableName = row["TABLE_NAME"].ToString();
                        ToolStripMenuItem button = new ToolStripMenuItem();
                        button.Text = tableName;
                        button.Font = new System.Drawing.Font("Segoe UI", 12F);
                        button.Size = new System.Drawing.Size(77, 25);
                        button.Click += (sender, e) => LoadDataInGrid.ExtractData(datagGridView,tableName,label);
                        menuStrip1 .Items.Add(button);
                    }                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }
    }
}
