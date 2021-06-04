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

       
        private void button1_Click(object sender, EventArgs e)
        {
            if(textBoxNamninput.TextLength==0 || textBoxFackinput.TextLength==0) //skriv in felmeddelande
                

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

            XmlElement root = (XmlElement)xmlDoc.SelectSingleNode("/root"); 

           

            //XmlElement kategoriElement = (XmlElement)xmlDoc.SelectSingleNode("/root/fack/kategori");
            
            XmlElement namnElement = xmlDoc.CreateElement("namn");
            XmlAttribute kategoriAttribute = xmlDoc.CreateAttribute("kategori");
            XmlAttribute datumAttribute = xmlDoc.CreateAttribute("datum");
            XmlAttribute idAttribute = xmlDoc.CreateAttribute("id"); 
            int facknummer = Convert.ToInt32(textBoxFackinput.Text);
            
            
            kategoriAttribute.InnerText = kategori;
            namnElement.InnerText = textBoxNamninput.Text;
            datumAttribute.Value = textBoxDatuminput.Text;

            namnElement.Attributes.Append(kategoriAttribute);
            namnElement.Attributes.Append(datumAttribute);
            if(facknummer == 1)
            {
                XmlElement fack = (XmlElement)xmlDoc.SelectSingleNode("/root/fack1");
            fack.AppendChild(namnElement);
                idAttribute.Value = "1";
                namnElement.Attributes.Append(idAttribute);
            }
            else if (facknummer == 2)
            {
                    XmlElement fack = (XmlElement)xmlDoc.SelectSingleNode("/root/fack2");
                fack.AppendChild(namnElement);
                idAttribute.Value = "2";
                namnElement.Attributes.Append(idAttribute);
            }
            else if (facknummer == 3)
            {
                    XmlElement fack = (XmlElement)xmlDoc.SelectSingleNode("/root/fack3");
                fack.AppendChild(namnElement);
                idAttribute.Value = "3";
                namnElement.Attributes.Append(idAttribute);
            }
            else if (facknummer == 4)
            {
                    XmlElement fack = (XmlElement)xmlDoc.SelectSingleNode("/root/fack4");
                fack.AppendChild(namnElement);
                idAttribute.Value = "4";
                namnElement.Attributes.Append(idAttribute);
            }
            else if (facknummer == 5)
            {
                    XmlElement fack = (XmlElement)xmlDoc.SelectSingleNode("/root/fack5");
                    fack.AppendChild(namnElement);
                idAttribute.Value = "5";
                namnElement.Attributes.Append(idAttribute);
            }
            else if (facknummer == 6)
            {
                XmlElement fack = (XmlElement)xmlDoc.SelectSingleNode("/root/fack6");
                fack.AppendChild(namnElement);
                idAttribute.Value = "6";
                namnElement.Attributes.Append(idAttribute);
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
