using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LearnForms1
{
    internal class DeleteRow
    {
        public static void deleteSelectRow(DataGridView dataGrid) 
        {
            DataGridViewSelectedRowCollection selectedRows = dataGrid.SelectedRows;
            foreach (DataGridViewRow row in selectedRows)
            {
                if (!row.IsNewRow)
                {
                    dataGrid.Rows.Remove(row);
                }
            }
        }
    }
}
