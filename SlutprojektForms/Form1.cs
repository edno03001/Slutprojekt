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
        /// <summary>
        /// anger en string path som blir filadressen
        /// </summary>
        string path = System.IO.Path.GetFileName("C:\\Users\\edno03001\\source\\repos\\Slutprojekt\\datafil.xml");
        XmlDocument xmlDoc = new XmlDocument();
        int senastKallad;

        public static Form1 Instance { get; private set; }

        public Form1()
        {
            InitializeComponent();
            Instance = this;
        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        public static void RaderaVara()
        {
            Instance.xmlDoc.Load(Instance.path);
            XmlNodeList senastKalladLista = Instance.xmlDoc.SelectSingleNode("/root/fack" + Instance.senastKallad).ChildNodes;
            Instance.populateItems(senastKalladLista);
        }


        /// <summary>
        /// lägger till en strip menu där en av knapparna öppnar upp ett nytt fönster där användaren kan lägga till nya varor
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

        }
        /// <summary>
        /// metod för att fylla usercontrollern ItemList med information från xml-filen, skapar en lista med noder
        /// </summary>
        /// <param name="nodeList"></param>
        private void populateItems(XmlNodeList nodeList)
        {
            flowLayoutPanel1.Controls.Clear();
            List<ItemList> itemslist = new List<ItemList>();
            xmlDoc.Load(path);

            foreach (XmlElement element in nodeList) ///för varje element i nodelist läggs det till en ny usercontrol
            {
                itemslist.Add(new ItemList());
            }

            for (int i = 0; i < itemslist.Count; i++) ///sätter de olika labels till elementen/attributernas innertext/value
            {
                itemslist[i].NamnTitel = nodeList[i].InnerText;
                itemslist[i].KategoriTitel = nodeList[i].Attributes["kategori"].Value; 
                itemslist[i].DatumTitel = nodeList[i].Attributes["datum"].Value;
                itemslist[i].FackTitel = nodeList[i].Attributes["id"].Value;
                flowLayoutPanel1.Controls.Add(itemslist[i]);
            }
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
        /// <summary>
        /// button1-6 är knappar för facken 1-6, fyller flowLayoutPanel1 med ItemList. Ifall facket i xml-filen är tomt 
        /// kommer ett felmeddelande
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            xmlDoc.Load(path);
            XmlNodeList fack1 = xmlDoc.SelectSingleNode("/root/fack1").ChildNodes;
            if (fack1.Count == 0) 
                MessageBox.Show("Vänligen försök igen, eller lägg till en ny produkt", "Facket är tomt!");
            else
            {
                populateItems(fack1);
                senastKallad = 1;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            xmlDoc.Load(path);
            XmlNodeList fack2 = xmlDoc.SelectSingleNode("/root/fack2").ChildNodes;
            if (fack2.Count == 0)
                MessageBox.Show("Vänligen försök igen, eller lägg till en ny produkt", "Facket är tomt!");
            else
            {
                populateItems(fack2);
                senastKallad = 2;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            xmlDoc.Load(path);
            XmlNodeList fack3 = xmlDoc.SelectSingleNode("/root/fack3").ChildNodes;
            if (fack3.Count == 0)
                MessageBox.Show("Vänligen försök igen, eller lägg till en ny produkt", "Facket är tomt!");
            else
            {
                populateItems(fack3);
                senastKallad = 3;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            xmlDoc.Load(path);
            XmlNodeList fack4 = xmlDoc.SelectSingleNode("/root/fack4").ChildNodes;
            if (fack4.Count == 0)
                MessageBox.Show("Vänligen försök igen, eller lägg till en ny produkt", "Facket är tomt!");
            else
            {
                populateItems(fack4);
                senastKallad = 4;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            xmlDoc.Load(path);
            XmlNodeList fack5 = xmlDoc.SelectSingleNode("/root/fack5").ChildNodes;
            if (fack5.Count == 0)
                MessageBox.Show("Vänligen försök igen, eller lägg till en ny produkt", "Facket är tomt!");
            else
            {
                populateItems(fack5);
                senastKallad = 5;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            xmlDoc.Load(path);
            XmlNodeList fack6 = xmlDoc.SelectSingleNode("/root/fack6").ChildNodes;
            if(fack6.Count==0)
                MessageBox.Show("Vänligen försök igen, eller lägg till en ny produkt", "Facket är tomt!");
            else
            {
                populateItems(fack6);
                senastKallad = 6;
            }
        }

        private void buttonAvsluta_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonRensa_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
        }
    }
}
