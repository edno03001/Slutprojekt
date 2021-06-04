using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
    }
}
