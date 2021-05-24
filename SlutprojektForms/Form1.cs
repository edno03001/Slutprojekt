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


        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

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

        private void populateItems()
        {
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load(path);
            List<UserControl> itemlist = new List<UserControl>();

            for (int i = 0; i < itemlist.Count; i++)
            {
                XmlElement namn = (XmlElement)xmlDoc.SelectSingleNode("/root/fack/kategori/namn");
                if (flowLayoutPanel1.Controls.Count < 0)
                {
                    flowLayoutPanel1.Controls.Clear();
                }
                else
                    flowLayoutPanel1.Controls.Add(itemlist[i]);

            }
        }
    }
}
