using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;
using System.Xml;

namespace LearnForms1
{
    internal class LoadStorProc
    {
        public static void LoadProc(DataGridView dataGrid, TextBox txtBox)
        {
            //ПРОВЕРКА ВВЕДЕННОЙ СТРОКИ НА ВОЗМОЖНОСТЬ КОВНЕРТАЦИИ В INT
            if (!Int32.TryParse(txtBox.Text, out int id))
            {
                MessageBox.Show("Invalid data format");
                return;
            }

            //ОБЪЯВЛЕНИЕ ПЕРЕМЕННЫХ
            string sqlExpression = "inputObligation";
            DataSet dataSet = new DataSet();

            //РАБОТА С БД
            using (MySqlConnection connection = DBUtils.GetDBConnection()) 
            {
                MySqlCommand command = new MySqlCommand(sqlExpression, connection);
                command.CommandType = System.Data.CommandType.StoredProcedure;

                //РАБОТА С ХРАНИМОЙ ПРОЦЕДУРОЙ
                MySqlParameter id_sel = new MySqlParameter();
                id_sel.ParameterName = "@id_bond";
                id_sel.Value = id;
                command.Parameters.Add(id_sel);


                //ПОЛУЧЕНИЕ ДАННЫХ ИЗ ХРАНИМОЙ ПРОЦЕДУРЫ
                connection.Open();
                MySqlDataReader reader = command.ExecuteReader();
                DataTable dataTable = new DataTable("YourTableName");
                dataTable.Load(reader);
                dataSet.Tables.Add(dataTable);
                connection.Close();
            }

            //ПРОВЕРКА НА СУЩЕСТВОВАНИЕ ТАБЛИЦЫ, ХРАНЯЩЕЙ РЕЗУЛЬТАТЫ РАБОТЫ ЭТОГО МЕТОДА И ДОБАВЛЕНИЕ, ЕСЛИ ЕЁ НЕ СУЩЕСТВУЕТ
            if (!dataSet.Tables.Contains("YourTableName"))
            {
                dataSet.Tables.Add("YourTableName");
            }

            //ПРОВЕРКА НА СУЩЕСТВОВАНИЕ СТОЛБЦОВ ТАБЛИЦЫ, И ДОБАЫЛЕНИЕ ИХ, ЕСЛИ ОНИ ЕЩЕ НЕ СОЗДАНЫ
            if (dataGrid.Columns.Count == 0)
            {
                foreach (DataColumn column in dataSet.Tables["YourTableName"].Columns)
                {
                    dataGrid.Columns.Add(column.ColumnName, column.ColumnName);
                }
            }

            //ДОБАВЛЕНИЕ СТРОК В DATAGRIDVIEW
            foreach (DataRow row in dataSet.Tables["YourTableName"].Rows)
            {
                dataGrid.Rows.Add(row.ItemArray);
            }

            //ОЧИЩЕНИЕ ПОЛЯ ДЛЯ ВВОДА ID 
            txtBox.Clear();
        }
    }
}
