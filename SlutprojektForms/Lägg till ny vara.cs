using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.IO;
using System.Windows.Forms;

namespace SlutprojektForms
{

    public partial class Lägg_till_ny_vara : Form
    {
        string kategori; //Gör en string för kategorin som senare läggs till i xml
                         //XmlText textReader = new XmlText("C:\\Users\\edno03001\\source\repos\\Slutprojekt\\datafil.xml");
                         //textReader();
        string path = System.IO.Path.GetFileName("C:\\Users\\edno03001\\source\\repos\\Slutprojekt\\datafil.xml");
       
        public Lägg_till_ny_vara()
        {
            InitializeComponent();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e) //knapp för spara
        {

            if (checkBoxKött.Checked)
            {
                kategori = "kött";
            }
            else if (checkBoxGrönsaker.Checked)
            {
                kategori = "grönsaker";
            }
            else if (checkBoxFärdigaRätter.Checked)
            {
                kategori = "färdiga rätter";
            }
            else if (checkBoxBärFrukt.Checked)
            {
                kategori = "bär och frukt";
            }
            else if (checkBoxÖvrigt.Checked)
            {
                kategori = "övrigt";
            }

            XmlDocument xmlDoc = new XmlDocument(); //åkallar xmldocument
            xmlDoc.Load(path);

            XmlElement root = (XmlElement)xmlDoc.SelectSingleNode("/root"); //hittar facket


           
            XmlElement fack = (XmlElement)xmlDoc.SelectSingleNode("/root/fack");

            XmlElement kategoriElement = (XmlElement)xmlDoc.SelectSingleNode("/root/fack/kategori");
            XmlElement namnElement = xmlDoc.CreateElement("namn");
            XmlAttribute datumAttribute = xmlDoc.CreateAttribute("datum");


            if(fack !=null)
            {
                fack.Value = textBoxFackinput.Text;
                kategoriElement.InnerText = kategori;
                namnElement.InnerText = textBoxNamninput.Text;
                datumAttribute.Value = textBoxDatuminput.Text;

                fack.AppendChild(kategoriElement);
                kategoriElement.AppendChild(namnElement);
                namnElement.Attributes.Append(datumAttribute);
                root.AppendChild(fack);
            }
            
                
            

            xmlDoc.Save(path);

            this.Close();

            //xmlDoc.Save("datafil.xml");

           
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
