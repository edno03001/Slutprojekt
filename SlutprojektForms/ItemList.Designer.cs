
namespace SlutprojektForms
{
    partial class ItemList
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.labelNamn = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelFack = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.labelDatum = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.labelKategori = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.label1.Location = new System.Drawing.Point(3, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Namn:";
            // 
            // labelNamn
            // 
            this.labelNamn.AutoSize = true;
            this.labelNamn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.labelNamn.Location = new System.Drawing.Point(83, 14);
            this.labelNamn.Name = "labelNamn";
            this.labelNamn.Size = new System.Drawing.Size(41, 16);
            this.labelNamn.TabIndex = 1;
            this.labelNamn.Text = "namn";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label3.Location = new System.Drawing.Point(5, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Fack";
            // 
            // labelFack
            // 
            this.labelFack.AutoSize = true;
            this.labelFack.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.labelFack.Location = new System.Drawing.Point(83, 30);
            this.labelFack.Name = "labelFack";
            this.labelFack.Size = new System.Drawing.Size(33, 16);
            this.labelFack.TabIndex = 3;
            this.labelFack.Text = "fack";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label5.Location = new System.Drawing.Point(5, 50);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Datum:";
            // 
            // labelDatum
            // 
            this.labelDatum.AutoSize = true;
            this.labelDatum.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.labelDatum.Location = new System.Drawing.Point(83, 50);
            this.labelDatum.Name = "labelDatum";
            this.labelDatum.Size = new System.Drawing.Size(45, 16);
            this.labelDatum.TabIndex = 5;
            this.labelDatum.Text = "datum";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label7.Location = new System.Drawing.Point(5, 67);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 17);
            this.label7.TabIndex = 6;
            this.label7.Text = "Kategori:";
            // 
            // labelKategori
            // 
            this.labelKategori.AutoSize = true;
            this.labelKategori.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.labelKategori.Location = new System.Drawing.Point(83, 68);
            this.labelKategori.Name = "labelKategori";
            this.labelKategori.Size = new System.Drawing.Size(57, 16);
            this.labelKategori.TabIndex = 7;
            this.labelKategori.Text = "kategori";
            // 
            // ItemList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.labelKategori);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.labelDatum);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.labelFack);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.labelNamn);
            this.Controls.Add(this.label1);
            this.Name = "ItemList";
            this.Size = new System.Drawing.Size(393, 97);
            this.Load += new System.EventHandler(this.ItemList_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelNamn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelFack;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label labelDatum;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label labelKategori;
    }
}
