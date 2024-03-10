using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace LearnForms1
{
    public partial class Form1 : Form
    {
        public DataSet dataSet;
        private String nameTable;

        public Form1()
        {
            InitializeComponent();
        }

        //КНОПКА ОТКРЫТИЯ ТАБЛИЦЫ "PERSON"
        private void tStripTab1_Click(object sender, EventArgs e)
        {
            nameTable = "fin_asset";
            dataSet = LoadDataInGrid.ExtractData(dataGridView1, nameTable, labelNameTable);
        }

        //КНОПКА ОТКРЫТИЯ ТАБЛИЦЫ "JOB"
        private void tStripTab2_Click(object sender, EventArgs e)
        {
            nameTable = "bond";
            dataSet = LoadDataInGrid.ExtractData(dataGridView1, nameTable, labelNameTable);
        }

        private void tStripTab3_Click(object sender, EventArgs e)
        {
            nameTable = "tiker";
            dataSet = LoadDataInGrid.ExtractData(dataGridView1, nameTable, labelNameTable);
        }

        private void securityToolStripMenuItem_Click(object sender, EventArgs e)
        {
            nameTable = "securit";
            dataSet = LoadDataInGrid.ExtractData(dataGridView1, nameTable, labelNameTable);
        }


        //ОПИСАНИЕ КНОПКИ СОХРАНЕНИЯ ИЗМЕНЕНИЙ В ТАБЛИЦЕ ОБРАТНО В БД
        private void btnSaveTable_Click(object sender, EventArgs e)
        {
            SaveChangesInTable.SaveChanges(dataSet, nameTable);
        }



        private void txtBoxIdRowForDel_TextChanged(object sender, EventArgs e)
        {
        }


        //ОПИСАНИЕ КНОПКИ УДАЛЕНИЙ СТРОКИ ПО ID
        private void btnRemRow_Click(object sender, EventArgs e)
        {
            DelRowForId.DeleteRow(txtBoxIdRowForDel, dataSet, nameTable);
        }

        //ФУНКЦИЯ ХРАНИМОЙ ПРОЦЕДУРЫ
        private void button1_Click(object sender, EventArgs e)
        {
            LoadStorProc.LoadProc(dataGridView2, txtBoxIdForObl);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnClearObl_Click(object sender, EventArgs e)
        {
            try 
            {
                dataGridView2.Rows.RemoveAt(0);
                dataGridView2.Refresh();
            }
            catch(Exception r) { }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
