
namespace SlutprojektForms
{
    partial class Lägg_till_ny_vara
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.checkBoxKött = new System.Windows.Forms.CheckBox();
            this.checkBoxBärFrukt = new System.Windows.Forms.CheckBox();
            this.checkBoxGrönsaker = new System.Windows.Forms.CheckBox();
            this.checkBoxFärdigaRätter = new System.Windows.Forms.CheckBox();
            this.checkBoxÖvrigt = new System.Windows.Forms.CheckBox();
            this.textBoxKategori = new System.Windows.Forms.TextBox();
            this.textBoxNamn = new System.Windows.Forms.TextBox();
            this.textBoxDatum = new System.Windows.Forms.TextBox();
            this.textBoxNamninput = new System.Windows.Forms.TextBox();
            this.textBoxDatuminput = new System.Windows.Forms.TextBox();
            this.buttonSpara = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.textBoxFack = new System.Windows.Forms.TextBox();
            this.textBoxFackinput = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // checkBoxKött
            // 
            this.checkBoxKött.AutoSize = true;
            this.checkBoxKött.Font = new System.Drawing.Font("Arial", 15F);
            this.checkBoxKött.Location = new System.Drawing.Point(148, 120);
            this.checkBoxKött.Name = "checkBoxKött";
            this.checkBoxKött.Size = new System.Drawing.Size(65, 27);
            this.checkBoxKött.TabIndex = 0;
            this.checkBoxKött.Text = "Kött";
            this.checkBoxKött.UseVisualStyleBackColor = true;
            this.checkBoxKött.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // checkBoxBärFrukt
            // 
            this.checkBoxBärFrukt.AutoSize = true;
            this.checkBoxBärFrukt.Font = new System.Drawing.Font("Arial", 15F);
            this.checkBoxBärFrukt.Location = new System.Drawing.Point(148, 186);
            this.checkBoxBärFrukt.Name = "checkBoxBärFrukt";
            this.checkBoxBärFrukt.Size = new System.Drawing.Size(142, 27);
            this.checkBoxBärFrukt.TabIndex = 1;
            this.checkBoxBärFrukt.Text = "Bär och frukt";
            this.checkBoxBärFrukt.UseVisualStyleBackColor = true;
            // 
            // checkBoxGrönsaker
            // 
            this.checkBoxGrönsaker.AutoSize = true;
            this.checkBoxGrönsaker.Font = new System.Drawing.Font("Arial", 15F);
            this.checkBoxGrönsaker.Location = new System.Drawing.Point(148, 153);
            this.checkBoxGrönsaker.Name = "checkBoxGrönsaker";
            this.checkBoxGrönsaker.Size = new System.Drawing.Size(122, 27);
            this.checkBoxGrönsaker.TabIndex = 2;
            this.checkBoxGrönsaker.Text = "Grönsaker";
            this.checkBoxGrönsaker.UseVisualStyleBackColor = true;
            this.checkBoxGrönsaker.CheckedChanged += new System.EventHandler(this.checkBox3_CheckedChanged);
            // 
            // checkBoxFärdigaRätter
            // 
            this.checkBoxFärdigaRätter.AutoSize = true;
            this.checkBoxFärdigaRätter.Font = new System.Drawing.Font("Arial", 15F);
            this.checkBoxFärdigaRätter.Location = new System.Drawing.Point(148, 219);
            this.checkBoxFärdigaRätter.Name = "checkBoxFärdigaRätter";
            this.checkBoxFärdigaRätter.Size = new System.Drawing.Size(150, 27);
            this.checkBoxFärdigaRätter.TabIndex = 3;
            this.checkBoxFärdigaRätter.Text = "Färdiga rätter";
            this.checkBoxFärdigaRätter.UseVisualStyleBackColor = true;
            // 
            // checkBoxÖvrigt
            // 
            this.checkBoxÖvrigt.AutoSize = true;
            this.checkBoxÖvrigt.Font = new System.Drawing.Font("Arial", 15F);
            this.checkBoxÖvrigt.Location = new System.Drawing.Point(148, 252);
            this.checkBoxÖvrigt.Name = "checkBoxÖvrigt";
            this.checkBoxÖvrigt.Size = new System.Drawing.Size(82, 27);
            this.checkBoxÖvrigt.TabIndex = 4;
            this.checkBoxÖvrigt.Text = "Övrigt";
            this.checkBoxÖvrigt.UseVisualStyleBackColor = true;
            // 
            // textBoxKategori
            // 
            this.textBoxKategori.BackColor = System.Drawing.SystemColors.Control;
            this.textBoxKategori.Font = new System.Drawing.Font("Arial", 20F);
            this.textBoxKategori.Location = new System.Drawing.Point(12, 110);
            this.textBoxKategori.Multiline = true;
            this.textBoxKategori.Name = "textBoxKategori";
            this.textBoxKategori.Size = new System.Drawing.Size(130, 43);
            this.textBoxKategori.TabIndex = 5;
            this.textBoxKategori.Text = "Kategori";
            // 
            // textBoxNamn
            // 
            this.textBoxNamn.BackColor = System.Drawing.SystemColors.Control;
            this.textBoxNamn.Font = new System.Drawing.Font("Arial", 20F);
            this.textBoxNamn.Location = new System.Drawing.Point(12, 12);
            this.textBoxNamn.Multiline = true;
            this.textBoxNamn.Name = "textBoxNamn";
            this.textBoxNamn.Size = new System.Drawing.Size(130, 43);
            this.textBoxNamn.TabIndex = 6;
            this.textBoxNamn.Text = "Namn";
            // 
            // textBoxDatum
            // 
            this.textBoxDatum.BackColor = System.Drawing.SystemColors.Control;
            this.textBoxDatum.Font = new System.Drawing.Font("Arial", 20F);
            this.textBoxDatum.Location = new System.Drawing.Point(12, 61);
            this.textBoxDatum.Multiline = true;
            this.textBoxDatum.Name = "textBoxDatum";
            this.textBoxDatum.Size = new System.Drawing.Size(130, 43);
            this.textBoxDatum.TabIndex = 7;
            this.textBoxDatum.Text = "Datum";
            // 
            // textBoxNamninput
            // 
            this.textBoxNamninput.BackColor = System.Drawing.SystemColors.Control;
            this.textBoxNamninput.Font = new System.Drawing.Font("Arial", 12F);
            this.textBoxNamninput.Location = new System.Drawing.Point(148, 21);
            this.textBoxNamninput.Multiline = true;
            this.textBoxNamninput.Name = "textBoxNamninput";
            this.textBoxNamninput.Size = new System.Drawing.Size(268, 25);
            this.textBoxNamninput.TabIndex = 8;
            this.textBoxNamninput.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // textBoxDatuminput
            // 
            this.textBoxDatuminput.BackColor = System.Drawing.SystemColors.Control;
            this.textBoxDatuminput.Font = new System.Drawing.Font("Arial", 12F);
            this.textBoxDatuminput.Location = new System.Drawing.Point(148, 70);
            this.textBoxDatuminput.Multiline = true;
            this.textBoxDatuminput.Name = "textBoxDatuminput";
            this.textBoxDatuminput.Size = new System.Drawing.Size(268, 25);
            this.textBoxDatuminput.TabIndex = 9;
            this.textBoxDatuminput.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // buttonSpara
            // 
            this.buttonSpara.Font = new System.Drawing.Font("Arial", 20F);
            this.buttonSpara.Location = new System.Drawing.Point(12, 357);
            this.buttonSpara.Name = "buttonSpara";
            this.buttonSpara.Size = new System.Drawing.Size(193, 68);
            this.buttonSpara.TabIndex = 10;
            this.buttonSpara.Text = "Spara";
            this.buttonSpara.UseVisualStyleBackColor = true;
            this.buttonSpara.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Arial", 20F);
            this.button2.Location = new System.Drawing.Point(211, 357);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(193, 68);
            this.button2.TabIndex = 11;
            this.button2.Text = "Exit";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBoxFack
            // 
            this.textBoxFack.BackColor = System.Drawing.SystemColors.Control;
            this.textBoxFack.Font = new System.Drawing.Font("Arial", 20F);
            this.textBoxFack.Location = new System.Drawing.Point(12, 274);
            this.textBoxFack.Multiline = true;
            this.textBoxFack.Name = "textBoxFack";
            this.textBoxFack.Size = new System.Drawing.Size(130, 43);
            this.textBoxFack.TabIndex = 12;
            this.textBoxFack.Text = "Fack";
            // 
            // textBoxFackinput
            // 
            this.textBoxFackinput.BackColor = System.Drawing.SystemColors.Control;
            this.textBoxFackinput.Font = new System.Drawing.Font("Arial", 12F);
            this.textBoxFackinput.Location = new System.Drawing.Point(148, 285);
            this.textBoxFackinput.Multiline = true;
            this.textBoxFackinput.Name = "textBoxFackinput";
            this.textBoxFackinput.Size = new System.Drawing.Size(268, 25);
            this.textBoxFackinput.TabIndex = 13;
            this.textBoxFackinput.TextChanged += new System.EventHandler(this.textBox7_TextChanged);
            // 
            // Lägg_till_ny_vara
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(428, 450);
            this.Controls.Add(this.textBoxFackinput);
            this.Controls.Add(this.textBoxFack);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.buttonSpara);
            this.Controls.Add(this.textBoxDatuminput);
            this.Controls.Add(this.textBoxNamninput);
            this.Controls.Add(this.textBoxDatum);
            this.Controls.Add(this.textBoxNamn);
            this.Controls.Add(this.textBoxKategori);
            this.Controls.Add(this.checkBoxÖvrigt);
            this.Controls.Add(this.checkBoxFärdigaRätter);
            this.Controls.Add(this.checkBoxGrönsaker);
            this.Controls.Add(this.checkBoxBärFrukt);
            this.Controls.Add(this.checkBoxKött);
            this.Name = "Lägg_till_ny_vara";
            this.Text = "Lägg till ny vara";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox checkBoxKött;
        private System.Windows.Forms.CheckBox checkBoxBärFrukt;
        private System.Windows.Forms.CheckBox checkBoxGrönsaker;
        private System.Windows.Forms.CheckBox checkBoxFärdigaRätter;
        private System.Windows.Forms.CheckBox checkBoxÖvrigt;
        private System.Windows.Forms.TextBox textBoxKategori;
        private System.Windows.Forms.TextBox textBoxNamn;
        private System.Windows.Forms.TextBox textBoxDatum;
        private System.Windows.Forms.TextBox textBoxNamninput;
        private System.Windows.Forms.TextBox textBoxDatuminput;
        private System.Windows.Forms.Button buttonSpara;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBoxFack;
        private System.Windows.Forms.TextBox textBoxFackinput;
    }
}