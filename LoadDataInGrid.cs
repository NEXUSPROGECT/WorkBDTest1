﻿using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace LearnForms1
{
    internal class LoadDataInGrid
    {
        public static DataSet ExtractData(DataGridView dataGridView1, string nameTable, Label labelTable)
        {
            DataSet dataSet = new DataSet();
            try
            {
                using (MySqlConnection connection = DBUtils.GetDBConnection())
                {
                    connection.Open();
                    string query = $"SELECT * FROM {nameTable}";
                    MySqlCommand command = new MySqlCommand(query, connection);
                    MySqlDataReader reader = command.ExecuteReader();
                    DataTable dataTable = new DataTable(nameTable);
                    dataTable.Load(reader);
                    dataSet.Tables.Add(dataTable);
                    connection.Close();
                }
                labelTable.Text = nameTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            if (dataSet.Tables.Count > 0)
            {
                dataGridView1.DataSource = dataSet.Tables[nameTable];
            }
            else
            {
                MessageBox.Show("Your table does not have data.");
            }
            return dataSet;
        }
    }
}
