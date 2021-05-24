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
    public partial class UserControl : System.Windows.Forms.UserControl
    {
        public UserControl()
        {
            InitializeComponent();
        }

        #region Properties

        private string fack;
        private string kategori;
        private string namn;
        private string datum;

        public string Fack
        {
            set { labelFack.Text = fack; }
        }
        public string Kategori
        {
            set { labelKategori.Text = kategori; }
        }
        public string Namn
        {
            set { labelNamn.Text = namn; }
        }
        public string Datum
        {
            set { labelDatum.Text = datum; }
        }


        #endregion
    }
}
