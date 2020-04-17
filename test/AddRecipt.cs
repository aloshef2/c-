using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.IO;
using System.Security.Cryptography;

namespace test
{
    public partial class AddRecipt : MetroFramework.Forms.MetroForm
    {
        public AddRecipt()
        {
            InitializeComponent();
        }

        private void Add_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "backerDataSet2.ricept". При необходимости она может быть перемещена или удалена.
            this.riceptTableAdapter.Fill(this.backerDataSet2.ricept);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "backerDataSet1.recipt". При необходимости она может быть перемещена или удалена.
            this.reciptTableAdapter.Fill(this.backerDataSet1.recipt);

        }

        private static void createXML()
        {
            
        }

        public static Int16 Get16BitHash2(string s)
        {
            using (var md5Hasher = MD5.Create())
            {
                var data = md5Hasher.ComputeHash(Encoding.UTF8.GetBytes(s));
                return BitConverter.ToInt16(data, 0);
            }
        }



        private void createRicept_Click(object sender, EventArgs e)
        {

            
            var xmlTextWriter = new XmlTextWriter("ricept.xml", Encoding.UTF8) 
            {
                Formatting = Formatting.Indented
            };

            xmlTextWriter.WriteStartDocument();
            xmlTextWriter.WriteStartElement("Ricept");
            xmlTextWriter.WriteElementString("Title", titlericept.Text);
            try
            {
                for (int j = 0; j < ReciptXml.Rows.Count; j++)
                {
                    for (int i = 0; i < ReciptXml.Rows[j].Cells.Count; i++)
                    {
                        
                        xmlTextWriter.WriteElementString("id", Guid.NewGuid().ToString());
                        xmlTextWriter.WriteElementString("nameRicept", ReciptXml.Rows[j].Cells[i].Value.ToString()) ;
                        xmlTextWriter.WriteElementString("valueRicept", ReciptXml.Rows[j].Cells[i].Value.ToString());
                    }
                }
                xmlTextWriter.WriteEndElement();
                xmlTextWriter.Close();

                MessageBox.Show("Файл успешно сохранен");
                
            }
            catch
            {
                MessageBox.Show("Ошибка при сохранении файла!");
            }

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
