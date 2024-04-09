using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace LearnForms1
{
    internal class SearchData
    {
        //private DataTable originalDataTable;

        public static void PerformSearch(DataGridView dataGridView)
        {
            DataTable originalDataTable = null;
            string searchText = Interaction.InputBox("Prompt", "Title", "Default", -1, -1);

            if (dataGridView.DataSource is DataTable dataTable)
            {
                originalDataTable = dataTable.Copy();
            }

            if (originalDataTable == null)
            {
                MessageBox.Show("Не задан источник данных для DataGridView.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrEmpty(searchText))
            {
                dataGridView.DataSource = originalDataTable;
                return;
            }

            try
            {
                var rows = originalDataTable.AsEnumerable().Where(row =>
                {
                    foreach (DataColumn column in originalDataTable.Columns)
                    {
                        if (row[column].ToString().Contains(searchText))
                            return true;
                    }
                    return false;
                }).ToArray();

                if (rows.Length > 0)
                {
                    DataTable resultTable = rows.CopyToDataTable();
                    dataGridView.DataSource = resultTable;
                }
                else
                {
                    dataGridView.DataSource = null;
                    MessageBox.Show("Ничего не найдено.", "Результат поиска", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при выполнении поиска: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
