using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;


namespace LearnForms1
{
    //internal class SaveChagesInTable
    //{
    //    public static void SaveChagenges(DataSet dataSet, String nameTable) 
    //    {
    //        using (MySqlConnection connection = DBUtils.GetDBConnection())
    //        {
    //            try 
    //            {
    //                connection.Open();
    //                MySqlDataAdapter adapter1 = new MySqlDataAdapter($"SELECT * FROM {nameTable}", connection);
    //                MySqlCommandBuilder builder1 = new MySqlCommandBuilder(adapter1);
    //                adapter1.Update(dataSet, nameTable);
    //                connection.Close();
    //            }
    //            catch(Exception e) 
    //            {
    //                MessageBox.Show(e.Message);
    //                return;
    //            }                                  
    //        }
    //    }
    //}


    internal class SaveChangesInTable
    {
        public static void SaveChanges(DataSet dataSet, string nameTable)
        {
            using (MySqlConnection connection = DBUtils.GetDBConnection())
            {
                try
                {
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
