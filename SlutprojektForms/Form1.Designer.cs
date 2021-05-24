
namespace SlutprojektForms
{
    partial class Form1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.läggTillNyVaraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sparaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.visaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.allaVarorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kategoriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.köttToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grönsakerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fruktOchGröntToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.färdigaRätterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.övrigtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.test = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.userControlCard1 = new SlutprojektForms.UserControl();
            this.menuStrip1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.visaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.läggTillNyVaraToolStripMenuItem,
            this.sparaToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.fileToolStripMenuItem.Text = "Arkiv";
            this.fileToolStripMenuItem.Click += new System.EventHandler(this.fileToolStripMenuItem_Click);
            // 
            // läggTillNyVaraToolStripMenuItem
            // 
            this.läggTillNyVaraToolStripMenuItem.Name = "läggTillNyVaraToolStripMenuItem";
            this.läggTillNyVaraToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.läggTillNyVaraToolStripMenuItem.Text = "Lägg till ny vara";
            this.läggTillNyVaraToolStripMenuItem.Click += new System.EventHandler(this.läggTillNyVaraToolStripMenuItem_Click);
            // 
            // sparaToolStripMenuItem
            // 
            this.sparaToolStripMenuItem.Name = "sparaToolStripMenuItem";
            this.sparaToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.sparaToolStripMenuItem.Text = "Spara";
            // 
            // visaToolStripMenuItem
            // 
            this.visaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.allaVarorToolStripMenuItem,
            this.kategoriToolStripMenuItem});
            this.visaToolStripMenuItem.Name = "visaToolStripMenuItem";
            this.visaToolStripMenuItem.Size = new System.Drawing.Size(40, 20);
            this.visaToolStripMenuItem.Text = "Visa";
            // 
            // allaVarorToolStripMenuItem
            // 
            this.allaVarorToolStripMenuItem.Name = "allaVarorToolStripMenuItem";
            this.allaVarorToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.allaVarorToolStripMenuItem.Text = "Alla varor";
            this.allaVarorToolStripMenuItem.Click += new System.EventHandler(this.allaVarorToolStripMenuItem_Click);
            // 
            // kategoriToolStripMenuItem
            // 
            this.kategoriToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.köttToolStripMenuItem,
            this.grönsakerToolStripMenuItem,
            this.fruktOchGröntToolStripMenuItem,
            this.färdigaRätterToolStripMenuItem,
            this.övrigtToolStripMenuItem});
            this.kategoriToolStripMenuItem.Name = "kategoriToolStripMenuItem";
            this.kategoriToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.kategoriToolStripMenuItem.Text = "Kategori";
            // 
            // köttToolStripMenuItem
            // 
            this.köttToolStripMenuItem.Name = "köttToolStripMenuItem";
            this.köttToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.köttToolStripMenuItem.Text = "Kött";
            // 
            // grönsakerToolStripMenuItem
            // 
            this.grönsakerToolStripMenuItem.Name = "grönsakerToolStripMenuItem";
            this.grönsakerToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.grönsakerToolStripMenuItem.Text = "Grönsaker";
            // 
            // fruktOchGröntToolStripMenuItem
            // 
            this.fruktOchGröntToolStripMenuItem.Name = "fruktOchGröntToolStripMenuItem";
            this.fruktOchGröntToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.fruktOchGröntToolStripMenuItem.Text = "Bär och frukt";
            // 
            // färdigaRätterToolStripMenuItem
            // 
            this.färdigaRätterToolStripMenuItem.Name = "färdigaRätterToolStripMenuItem";
            this.färdigaRätterToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.färdigaRätterToolStripMenuItem.Text = "Färdiga rätter";
            // 
            // övrigtToolStripMenuItem
            // 
            this.övrigtToolStripMenuItem.Name = "övrigtToolStripMenuItem";
            this.övrigtToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.övrigtToolStripMenuItem.Text = "Övrigt";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Window;
            this.button1.Font = new System.Drawing.Font("Arial", 20F);
            this.button1.Location = new System.Drawing.Point(12, 26);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(236, 84);
            this.button1.TabIndex = 1;
            this.button1.Text = "1";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.Window;
            this.button2.Font = new System.Drawing.Font("Arial", 20F);
            this.button2.Location = new System.Drawing.Point(12, 106);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(236, 84);
            this.button2.TabIndex = 2;
            this.button2.Text = "2";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.Window;
            this.button3.Font = new System.Drawing.Font("Arial", 20F);
            this.button3.Location = new System.Drawing.Point(12, 187);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(236, 84);
            this.button3.TabIndex = 3;
            this.button3.Text = "3";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.Window;
            this.button4.Font = new System.Drawing.Font("Arial", 20F);
            this.button4.Location = new System.Drawing.Point(12, 266);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(236, 84);
            this.button4.TabIndex = 4;
            this.button4.Text = "4";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.SystemColors.Window;
            this.button5.Font = new System.Drawing.Font("Arial", 20F);
            this.button5.Location = new System.Drawing.Point(12, 345);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(236, 84);
            this.button5.TabIndex = 5;
            this.button5.Text = "5";
            this.button5.UseVisualStyleBackColor = false;
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.SystemColors.Window;
            this.button6.Font = new System.Drawing.Font("Arial", 20F);
            this.button6.Location = new System.Drawing.Point(12, 426);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(236, 84);
            this.button6.TabIndex = 6;
            this.button6.Text = "6";
            this.button6.UseVisualStyleBackColor = false;
            // 
            // test
            // 
            this.test.Location = new System.Drawing.Point(336, 462);
            this.test.Name = "test";
            this.test.Size = new System.Drawing.Size(75, 23);
            this.test.TabIndex = 8;
            this.test.Text = "test";
            this.test.UseVisualStyleBackColor = true;
            this.test.Click += new System.EventHandler(this.test_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.userControlCard1);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(254, 27);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(534, 402);
            this.flowLayoutPanel1.TabIndex = 9;
            // 
            // userControlCard1
            // 
            this.userControlCard1.Location = new System.Drawing.Point(3, 3);
            this.userControlCard1.Name = "userControlCard1";
            this.userControlCard1.Size = new System.Drawing.Size(300, 66);
            this.userControlCard1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 522);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.test);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Vad finns i frysen?";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem läggTillNyVaraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sparaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem visaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem allaVarorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kategoriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem köttToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem grönsakerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fruktOchGröntToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem färdigaRätterToolStripMenuItem;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.ToolStripMenuItem övrigtToolStripMenuItem;
        private System.Windows.Forms.Button test;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private UserControl userControlCard1;
    }
}

