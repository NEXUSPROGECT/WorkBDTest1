using System;
using System.Data;
using System.Windows.Forms;

namespace LearnForms1
{
    public partial class Formm1 : Form
    {
        public Formm1()
        {
            CreateStockXml.CreateXml();
            InitializeComponent();
            this.Text = $"NekoPaper [{IndicateConnectBD.examConnect()}]";
            AddTablesFromBD.LoadTables(dataGridView1, menuStrip1, labelNameTable);
            dataGridView1.CellEndEdit += dataGridView1_CellEndEdit;
        }

        //ОПИСАНИЕ КНОПКИ СОХРАНЕНИЯ ИЗМЕНЕНИЙ В ТАБЛИЦЕ ОБРАТНО В БД
        private void btnSaveTable_Click(object sender, EventArgs e)
        {
            SaveChangesInTable.SaveChanges(dataGridView1);
        }

        //ОПИСАНИЕ КНОПКИ ДОБАВЛЕНИЯ СТРОКИ
        //
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (dataGridView1.DataSource as DataTable != null)
            {
                dataGridView1.AllowUserToAddRows = true;
            }
            else { MessageBox.Show("Таблица не открыта"); }
        }
        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView1.AllowUserToAddRows = false;
        }
        //

        //ОПИСАНИЕ КНОПКИ УДАЛЕНИЙ СТРОКИ ПО ID
        private void btnRemRow_Click(object sender, EventArgs e)
        {
            DeleteRow.deleteSelectRow(dataGridView1);
        }

        //ФУНКЦИЯ ХРАНИМОЙ ПРОЦЕДУРЫ
        private void btnStoreProc_Click(object sender, EventArgs e)
        {
            LoadStorProc.LoadProc(dataGridView2, txtBoxIdForObl);
        }

        //ОЧИЩЕНИЕ СТРОК В ТАБЛИЦЕ ОБЛИГАЦИЙ
        private void btnClearObl_Click(object sender, EventArgs e)
        {
            DeleteRow.deleteSelectRow(dataGridView2);
        }

        private void btnSet_Click(object sender, EventArgs e)
        {
            FormSetcs formSetcs = new FormSetcs();
            formSetcs.Show();
        }
    }
}
