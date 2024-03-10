using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace LearnForms1
{
    public partial class Formm1 : Form
    {
        public DataSet dataSet;
        private String nameTable;
       

        public Formm1()
        {
            InitializeComponent();
            this.Text = $"NekoPaper [{IndicateConnectBD.examConnect()}]";
        }

        //КНОПКА ОТКРЫТИЯ ТАБЛИЦЫ "PERSON"
        private void finAsset_Click(object sender, EventArgs e)
        {
            OpenTable("fin_asset");
        }

        //КНОПКА ОТКРЫТИЯ ТАБЛИЦЫ "JOB"
        private void bond_Click(object sender, EventArgs e)
        {
            OpenTable("bond");
        }

        private void tiker_Click(object sender, EventArgs e)
        {
            OpenTable("tiker");
        }

        private void security_Click(object sender, EventArgs e)
        {
            OpenTable("serurit");
        }


        //ОПИСАНИЕ КНОПКИ СОХРАНЕНИЯ ИЗМЕНЕНИЙ В ТАБЛИЦЕ ОБРАТНО В БД
        private void btnSaveTable_Click(object sender, EventArgs e)
        {
            SaveChangesInTable.SaveChanges(dataSet, nameTable);
        } 


        //ОПИСАНИЕ КНОПКИ УДАЛЕНИЙ СТРОКИ ПО ID
        private void btnRemRow_Click(object sender, EventArgs e)
        {
            DelRowForId.DeleteRow(txtBoxIdRowForDel, dataSet, nameTable);
        }

        //ФУНКЦИЯ ХРАНИМОЙ ПРОЦЕДУРЫ
        private void btnStoreProc_Click(object sender, EventArgs e)
        {
            LoadStorProc.LoadProc(dataGridView2, txtBoxIdForObl);
        }

        private void btnClearObl_Click(object sender, EventArgs e)
        {
            try 
            {
                dataGridView2.Rows.RemoveAt(0);
                dataGridView2.Refresh();
            }
            catch(Exception r) { MessageBox.Show(r.Message); }
        }




        private void OpenTable(string tableName)
        {
            try
            {
                dataSet = LoadDataInGrid.ExtractData(dataGridView1, tableName, labelNameTable);
                nameTable = tableName;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to load data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
