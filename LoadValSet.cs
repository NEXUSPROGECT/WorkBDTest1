using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace LearnForms1
{
    internal class LoadValSet
    {
        public static void load(TextBox hostL, TextBox portL, TextBox nameBdL, TextBox usNameL, TextBox pasL) 
        {
            var doc = new XmlDocument();
            doc.Load(@"C:\Users\Vusez\source\repos\LearnForms1\Files\db_connection_values.xml");
            hostL.Text = doc.SelectSingleNode("/values/host").InnerText;
            portL.Text = doc.SelectSingleNode("/values/port").InnerText;
            nameBdL.Text = doc.SelectSingleNode("/values/database").InnerText;
            usNameL.Text = doc.SelectSingleNode("/values/username").InnerText;
            pasL.Text = doc.SelectSingleNode("/values/password").InnerText;
        }
    }
}
