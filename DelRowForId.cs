using System;
using System.Data;
using System.Windows.Forms;


namespace LearnForms1
{
    internal class DelRowForId
    {
        public static void DeleteRow(TextBox txtBoxIdRowForDel, DataSet dataSet, String nameTable)
        {
            if (!Int32.TryParse(txtBoxIdRowForDel.Text, out int j))
            {
                MessageBox.Show("ERROR: invalid DATA format");
            }

            try 
            {
                DataRow[] rows = dataSet.Tables[nameTable].Select($"ID = {Int32.Parse(txtBoxIdRowForDel.Text)}");
                foreach (DataRow row in rows)
                {
                    row.Delete();
                }
                txtBoxIdRowForDel.Clear();
            }
            catch(Exception e) {}
        }

       
    }
}
