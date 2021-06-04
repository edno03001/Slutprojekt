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
    public partial class ItemList : UserControl
    {
        public ItemList()
        {
            InitializeComponent();
        }

        private void ItemList_Load(object sender, EventArgs e)
        {

        }

        #region Properties
        /// <summary>
        /// skapar strings för de olika elementen och attrbuterna i xml-filen och sätter get,set metoder på dessa
        /// </summary>
        private string namn;
        private string fack;
        private string datum;
        private string kategori;

        [Category("Custom props")]
        public string NamnTitel
        {
            get { return namn; }
            set { namn = value; labelNamn.Text = value; }
        }
        [Category("Custom props")]
        public string FackTitel
        {
            get { return fack; }
            set { fack = value; labelFack.Text = value; }
        }
        [Category("Custom props")]
        public string DatumTitel
        {
            get { return datum; }
            set { datum = value; labelDatum.Text = value; }
        }
        [Category("Custom props")]
        public string KategoriTitel
        {
            get { return kategori; }
            set { kategori = value; labelKategori.Text = value; }
            
        }
        #endregion

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            string path = System.IO.Path.GetFileName("C:\\Users\\edno03001\\source\\repos\\Slutprojekt\\datafil.xml");
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load(path);

            XmlElement vara = (XmlElement)xmlDoc.SelectSingleNode("/root/fack" + fack + "/namn[@kategori='" + kategori + "' and @datum='" + datum + "']");
            if (vara != null)
            {
                vara.RemoveAll();
                vara.ParentNode.RemoveChild(vara);
                xmlDoc.Save(path);
                Form1.RaderaVara();
            }
        }
    }
}
