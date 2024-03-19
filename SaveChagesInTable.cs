using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace LearnForms1
{
    internal class SaveChangesInTable
    {
        public static void SaveChanges(DataGridView dataGridView)
        {
            using (MySqlConnection connection = DBUtils.GetDBConnection())
            {
                try
                {
                    string nameTable = "";
                    DataTable dataTable = dataGridView.DataSource as DataTable;
                    if(dataTable == null ) { return; }
                    nameTable = dataTable.TableName;
                    DataSet dataSet = dataTable?.DataSet;
                    
                    connection.Open();

                    foreach (DataRow row in dataSet.Tables[nameTable].Rows)
                    {
                        MySqlCommand command;
                        if (row.RowState == DataRowState.Added)
                        {
                            command = GetInsertCommand(nameTable, row, connection);
                        }
                        else if (row.RowState == DataRowState.Modified)
                        {
                            command = GetUpdateCommand(nameTable, row, connection);
                        }
                        else if (row.RowState == DataRowState.Deleted)
                        {
                            command = GetDeleteCommand(nameTable, row, connection);
                        }
                        else
                        {
                            continue; 
                        }

                        command.ExecuteNonQuery();
                    }

                    dataSet.Tables[nameTable].AcceptChanges();

                    connection.Close();
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message);
                    return;
                }
            }
        }

        private static MySqlCommand GetInsertCommand(string tableName, DataRow row, MySqlConnection connection)
        {
            List<string> columnValues = new List<string>();
            foreach (DataColumn column in row.Table.Columns)
            {
                if (column.DataType == typeof(DateTime) && row[column] != DBNull.Value)
                {
                    columnValues.Add($"'{((DateTime)row[column]).ToString("yyyy-MM-dd")}'");
                }
                else
                {
                    columnValues.Add($"'{row[column]}'");
                }
            }

            string columns = string.Join(",", row.Table.Columns.Cast<DataColumn>().Select(c => c.ColumnName));
            string values = string.Join(",", columnValues);
            string insertQuery = $"INSERT INTO {tableName} ({columns}) VALUES ({values})";
            return new MySqlCommand(insertQuery, connection);
        }

        private static MySqlCommand GetUpdateCommand(string tableName, DataRow row, MySqlConnection connection)
        {
            List<string> setValues = new List<string>();
            foreach (DataColumn column in row.Table.Columns)
            {
                if (column.DataType == typeof(DateTime) && row[column] != DBNull.Value)
                {
                    setValues.Add($"{column.ColumnName} = '{((DateTime)row[column]).ToString("yyyy-MM-dd")}'");
                }
                else
                {
                    setValues.Add($"{column.ColumnName} = '{row[column]}'");
                }
            }

            string updateQuery = $"UPDATE {tableName} SET {string.Join(",", setValues)} WHERE id = {row["id", DataRowVersion.Original]}";
            return new MySqlCommand(updateQuery, connection);
        }

        private static MySqlCommand GetDeleteCommand(string tableName, DataRow row, MySqlConnection connection)
        {
            string deleteQuery = $"DELETE FROM {tableName} WHERE id = {row["id", DataRowVersion.Original]}";
            return new MySqlCommand(deleteQuery, connection);
        }
    }


}
