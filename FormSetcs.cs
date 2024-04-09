using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LearnForms1
{
    public partial class FormSetcs : Form
    {
        public FormSetcs()
        {
            InitializeComponent();
            LoadValSet.load(txtBoxHost,txtBoxPort,txtBoxNamDB,txtBoxUsNam,txtBoxPas, txtBoxNameSP, txtBoxNamPar);
        }

        private void btnAp_Click(object sender, EventArgs e)
        {
            SaveBDVal.Load(txtBoxHost, txtBoxPort, txtBoxNamDB, txtBoxUsNam, txtBoxPas, txtBoxNameSP, txtBoxNamPar);
            DialogResult result = MessageBox.Show("Необходимо перезапустить приложение. Сделать это сейчас?", "Необходим перезапуск", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                Application.Restart();
            }
            else
            {
                this.Close();
            }
        }
    }
}
