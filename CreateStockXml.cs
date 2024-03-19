using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace LearnForms1
{
    internal class CreateStockXml
    {
        public static void CreateXml() 
        {
            try 
            {
                var doc1 = new XmlDocument();
                doc1.Load(@"C:\Users\Vusez\source\repos\LearnForms1\Files\db_connection_values.xml");
            }
            catch 
            {
                // Создание нового XML документа
                var doc = new XmlDocument();

                // Создание корневого элемент
                var root = doc.CreateElement("values");
                doc.AppendChild(root);

                // Создание и добавление переменных
                var variable1 = doc.CreateElement("host");
                variable1.InnerText = "127.0.0.1";
                root.AppendChild(variable1);

                var variable2 = doc.CreateElement("port");
                variable2.InnerText = "3306";
                root.AppendChild(variable2);

                var variable3 = doc.CreateElement("database");
                variable3.InnerText = "paper_accounting";
                root.AppendChild(variable3);

                var variable4 = doc.CreateElement("username");
                variable4.InnerText = "root";
                root.AppendChild(variable4);

                var variable5 = doc.CreateElement("password");
                variable5.InnerText = "rootPass123";
                root.AppendChild(variable5);

                // Сохранение XML файла
                doc.Save(@"C:\Users\Vusez\source\repos\LearnForms1\Files\db_connection_values.xml");
            }
        } 
    }
}
