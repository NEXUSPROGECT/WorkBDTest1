using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace LearnForms1
{
    internal class SaveBDVal
    {
        public static void Load(TextBox hostL, TextBox portL, TextBox nameBdL, TextBox usNameL, TextBox pasL, TextBox nameSPL, TextBox namParL)
        {
            var doc = new XmlDocument();
            doc.Load(@"C:\Users\Vusez\source\repos\LearnForms1\Files\db_connection_values.xml");

            var host = doc.SelectSingleNode("/values/host");
            host.InnerText = hostL.Text;

            var port = doc.SelectSingleNode("/values/port");
            port.InnerText = portL.Text;

            var nameBd = doc.SelectSingleNode("/values/database");
            nameBd.InnerText = nameBdL.Text;

            var usName = doc.SelectSingleNode("/values/username");
            usName.InnerText = usNameL.Text;

            var pas = doc.SelectSingleNode("/values/password");
            pas.InnerText = pasL.Text;

            var nameSP = doc.SelectSingleNode("/values/nameStorPoc");
            nameSP.InnerText = nameSPL.Text;

            var namPar = doc.SelectSingleNode("/values/parameterName");
            namPar.InnerText = namParL.Text;

            // Сохранение XML файла
            doc.Save(@"C:\Users\Vusez\source\repos\LearnForms1\Files\db_connection_values.xml");
        }
    }
}
