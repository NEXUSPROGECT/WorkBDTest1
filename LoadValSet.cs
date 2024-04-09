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
        public static void load(TextBox host, TextBox port, TextBox nameBd, TextBox usName, TextBox pas, TextBox nameSP, TextBox namPar) 
        {
            var doc = new XmlDocument();
            doc.Load(@"C:\Users\Vusez\source\repos\LearnForms1\Files\db_connection_values.xml");
            host.Text = doc.SelectSingleNode("/values/host").InnerText;
            port.Text = doc.SelectSingleNode("/values/port").InnerText;
            nameBd.Text = doc.SelectSingleNode("/values/database").InnerText;
            usName.Text = doc.SelectSingleNode("/values/username").InnerText;
            pas.Text = doc.SelectSingleNode("/values/password").InnerText;
            nameSP.Text = doc.SelectSingleNode("/values/nameStorPoc").InnerText;
            namPar.Text = doc.SelectSingleNode("/values/parameterName").InnerText;
        }
    }
}
