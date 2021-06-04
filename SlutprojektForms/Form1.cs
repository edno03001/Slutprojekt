using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Windows.Forms;

namespace SlutprojektForms
{
    public partial class Form1 : Form
    {
        string path = System.IO.Path.GetFileName("C:\\Users\\edno03001\\source\\repos\\Slutprojekt\\datafil.xml");
        XmlDocument xmlDoc = new XmlDocument();

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            xmlDoc.Load(path);
            XmlNodeList fack1 = xmlDoc.SelectSingleNode("/root/fack1").ChildNodes;
            if (fack1.Count == 0)
                MessageBox.Show("Vänligen försök igen, eller lägg till en ny produkt", "Facket är tomt!");
            else
                populateItems(fack1);
        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            xmlDoc.Load(path);
            XmlNodeList fack2 = xmlDoc.SelectSingleNode("/root/fack2").ChildNodes;
            if (fack2.Count == 0)
                MessageBox.Show("Vänligen försök igen, eller lägg till en ny produkt", "Facket är tomt!");
            else
                populateItems(fack2);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void läggTillNyVaraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Lägg_till_ny_vara form = new Lägg_till_ny_vara();
            form.Show();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void allaVarorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void test_Click(object sender, EventArgs e)
        {
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load(path);


            //plats för fil: C:\Users\edno03001\source\repos\Slutprojekt\SlutprojektForms\bin\Debug
        }

        private void populateItems(XmlNodeList nodeList)
        {
            xmlDoc.Load(path);
            List<ItemList> itemslist = new List<ItemList>();

            foreach (XmlElement element in nodeList)
            {
                itemslist.Add(new ItemList());

            }

            //XmlElement namn = (XmlElement)xmlDoc.SelectSingleNode("/root/fack/namn");
            
            for (int i = 0; i < itemslist.Count; i++)
            {
                //if(itemslist[i].KategoriTitel!=null && itemslist[i].DatumTitel!=null)
                {
                    itemslist[i].NamnTitel = nodeList[i].InnerText;
                    itemslist[i].KategoriTitel = nodeList[i].Attributes["kategori"].Value; //attributerna blir null
                    itemslist[i].DatumTitel = nodeList[i].Attributes["datum"].Value;
                    flowLayoutPanel1.Controls.Add(itemslist[i]);
                }
                
            }
            
            
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            xmlDoc.Load(path);
            XmlNodeList fack3 = xmlDoc.SelectSingleNode("/root/fack3").ChildNodes;
            if (fack3.Count == 0)
                MessageBox.Show("Vänligen försök igen, eller lägg till en ny produkt", "Facket är tomt!");
            else
                populateItems(fack3);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            xmlDoc.Load(path);
            XmlNodeList fack4 = xmlDoc.SelectSingleNode("/root/fack4").ChildNodes;
            if (fack4.Count == 0)
                MessageBox.Show("Vänligen försök igen, eller lägg till en ny produkt", "Facket är tomt!");
            else
                populateItems(fack4);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            xmlDoc.Load(path);
            XmlNodeList fack5 = xmlDoc.SelectSingleNode("/root/fack5").ChildNodes;
            if (fack5.Count == 0)
                MessageBox.Show("Vänligen försök igen, eller lägg till en ny produkt", "Facket är tomt!");
            else
                populateItems(fack5);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            xmlDoc.Load(path);
            XmlNodeList fack6 = xmlDoc.SelectSingleNode("/root/fack6").ChildNodes;
            if(fack6.Count==0)
                MessageBox.Show("Vänligen försök igen, eller lägg till en ny produkt", "Facket är tomt!");
            else
                populateItems(fack6);

        }
    }
}
