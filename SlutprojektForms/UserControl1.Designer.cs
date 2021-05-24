
namespace SlutprojektForms
{
    partial class UserControl
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
            this.labelFack = new System.Windows.Forms.Label();
            this.labelKategori = new System.Windows.Forms.Label();
            this.labelNamn = new System.Windows.Forms.Label();
            this.labelDatum = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelFack
            // 
            this.labelFack.AutoSize = true;
            this.labelFack.Location = new System.Drawing.Point(0, 0);
            this.labelFack.Name = "labelFack";
            this.labelFack.Size = new System.Drawing.Size(35, 13);
            this.labelFack.TabIndex = 0;
            this.labelFack.Text = "label1";
            // 
            // labelKategori
            // 
            this.labelKategori.AutoSize = true;
            this.labelKategori.Location = new System.Drawing.Point(34, 24);
            this.labelKategori.Name = "labelKategori";
            this.labelKategori.Size = new System.Drawing.Size(35, 13);
            this.labelKategori.TabIndex = 1;
            this.labelKategori.Text = "label2";
            // 
            // labelNamn
            // 
            this.labelNamn.AutoSize = true;
            this.labelNamn.Location = new System.Drawing.Point(105, 12);
            this.labelNamn.Name = "labelNamn";
            this.labelNamn.Size = new System.Drawing.Size(35, 13);
            this.labelNamn.TabIndex = 2;
            this.labelNamn.Text = "label3";
            // 
            // labelDatum
            // 
            this.labelDatum.AutoSize = true;
            this.labelDatum.Location = new System.Drawing.Point(146, 8);
            this.labelDatum.Name = "labelDatum";
            this.labelDatum.Size = new System.Drawing.Size(35, 13);
            this.labelDatum.TabIndex = 3;
            this.labelDatum.Text = "label4";
            // 
            // UserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.labelDatum);
            this.Controls.Add(this.labelNamn);
            this.Controls.Add(this.labelKategori);
            this.Controls.Add(this.labelFack);
            this.Name = "UserControl";
            this.Size = new System.Drawing.Size(300, 66);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelFack;
        private System.Windows.Forms.Label labelKategori;
        private System.Windows.Forms.Label labelNamn;
        private System.Windows.Forms.Label labelDatum;
    }
}
