namespace AddRemotePrinters
{
    partial class AddRemotePrinters
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxSerwerWydruku = new System.Windows.Forms.TextBox();
            this.buttonWyszukajDrukarki = new System.Windows.Forms.Button();
            this.buttonWyszukajKomputery = new System.Windows.Forms.Button();
            this.textBoxNazwaDomeny = new System.Windows.Forms.TextBox();
            this.checkedListBoxPrinters = new System.Windows.Forms.CheckedListBox();
            this.checkedListBoxKomputery = new System.Windows.Forms.CheckedListBox();
            this.buttonZainstalujDrukarki = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.radioButtonDodajDrukarke = new System.Windows.Forms.RadioButton();
            this.radioButtonUsunDrukarke = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemWyszukajAutomatycznie = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            this.menuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(304, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nazwa domeny";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(67, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(194, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Adres serwera wydruku";
            // 
            // textBoxSerwerWydruku
            // 
            this.textBoxSerwerWydruku.Location = new System.Drawing.Point(12, 47);
            this.textBoxSerwerWydruku.Name = "textBoxSerwerWydruku";
            this.textBoxSerwerWydruku.Size = new System.Drawing.Size(185, 20);
            this.textBoxSerwerWydruku.TabIndex = 6;
            this.textBoxSerwerWydruku.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxUrlPrintServer_KeyDown);
            // 
            // buttonWyszukajDrukarki
            // 
            this.buttonWyszukajDrukarki.Location = new System.Drawing.Point(203, 44);
            this.buttonWyszukajDrukarki.Name = "buttonWyszukajDrukarki";
            this.buttonWyszukajDrukarki.Size = new System.Drawing.Size(75, 23);
            this.buttonWyszukajDrukarki.TabIndex = 7;
            this.buttonWyszukajDrukarki.Text = "Wyszukaj drukarki";
            this.buttonWyszukajDrukarki.UseVisualStyleBackColor = true;
            this.buttonWyszukajDrukarki.Click += new System.EventHandler(this.buttonWyszukajDrukarki_Click);
            // 
            // buttonWyszukajKomputery
            // 
            this.buttonWyszukajKomputery.Location = new System.Drawing.Point(459, 45);
            this.buttonWyszukajKomputery.Name = "buttonWyszukajKomputery";
            this.buttonWyszukajKomputery.Size = new System.Drawing.Size(75, 23);
            this.buttonWyszukajKomputery.TabIndex = 9;
            this.buttonWyszukajKomputery.Text = "Wyszukaj drukarki";
            this.buttonWyszukajKomputery.UseVisualStyleBackColor = true;
            this.buttonWyszukajKomputery.Click += new System.EventHandler(this.buttonWyszukajKomputery_Click);
            // 
            // textBoxNazwaDomeny
            // 
            this.textBoxNazwaDomeny.Location = new System.Drawing.Point(284, 47);
            this.textBoxNazwaDomeny.Name = "textBoxNazwaDomeny";
            this.textBoxNazwaDomeny.Size = new System.Drawing.Size(169, 20);
            this.textBoxNazwaDomeny.TabIndex = 8;
            this.textBoxNazwaDomeny.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxNazwaDomeny_KeyDown);
            // 
            // checkedListBoxPrinters
            // 
            this.checkedListBoxPrinters.FormattingEnabled = true;
            this.checkedListBoxPrinters.Location = new System.Drawing.Point(12, 71);
            this.checkedListBoxPrinters.Name = "checkedListBoxPrinters";
            this.checkedListBoxPrinters.Size = new System.Drawing.Size(266, 574);
            this.checkedListBoxPrinters.TabIndex = 10;
            // 
            // checkedListBoxKomputery
            // 
            this.checkedListBoxKomputery.FormattingEnabled = true;
            this.checkedListBoxKomputery.Location = new System.Drawing.Point(284, 71);
            this.checkedListBoxKomputery.Name = "checkedListBoxKomputery";
            this.checkedListBoxKomputery.Size = new System.Drawing.Size(250, 574);
            this.checkedListBoxKomputery.TabIndex = 11;
            // 
            // buttonZainstalujDrukarki
            // 
            this.buttonZainstalujDrukarki.Location = new System.Drawing.Point(284, 656);
            this.buttonZainstalujDrukarki.Name = "buttonZainstalujDrukarki";
            this.buttonZainstalujDrukarki.Size = new System.Drawing.Size(250, 38);
            this.buttonZainstalujDrukarki.TabIndex = 12;
            this.buttonZainstalujDrukarki.Text = "Wykonaj";
            this.buttonZainstalujDrukarki.UseVisualStyleBackColor = true;
            this.buttonZainstalujDrukarki.Click += new System.EventHandler(this.buttonZainstalujDrukarki_Click);
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // backgroundWorker2
            // 
            this.backgroundWorker2.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker2_DoWork);
            // 
            // radioButtonDodajDrukarke
            // 
            this.radioButtonDodajDrukarke.AutoSize = true;
            this.radioButtonDodajDrukarke.Location = new System.Drawing.Point(5, 3);
            this.radioButtonDodajDrukarke.Name = "radioButtonDodajDrukarke";
            this.radioButtonDodajDrukarke.Size = new System.Drawing.Size(100, 17);
            this.radioButtonDodajDrukarke.TabIndex = 17;
            this.radioButtonDodajDrukarke.TabStop = true;
            this.radioButtonDodajDrukarke.Text = "Dodaj Drukarkę";
            this.radioButtonDodajDrukarke.UseVisualStyleBackColor = true;
            // 
            // radioButtonUsunDrukarke
            // 
            this.radioButtonUsunDrukarke.AutoSize = true;
            this.radioButtonUsunDrukarke.Location = new System.Drawing.Point(150, 3);
            this.radioButtonUsunDrukarke.Name = "radioButtonUsunDrukarke";
            this.radioButtonUsunDrukarke.Size = new System.Drawing.Size(97, 17);
            this.radioButtonUsunDrukarke.TabIndex = 18;
            this.radioButtonUsunDrukarke.TabStop = true;
            this.radioButtonUsunDrukarke.Text = "Usuń Drukarkę";
            this.radioButtonUsunDrukarke.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.radioButtonDodajDrukarke);
            this.panel1.Controls.Add(this.radioButtonUsunDrukarke);
            this.panel1.Location = new System.Drawing.Point(12, 656);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(266, 38);
            this.panel1.TabIndex = 22;
            // 
            // menuStrip2
            // 
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem1});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(544, 24);
            this.menuStrip2.TabIndex = 26;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // menuToolStripMenuItem1
            // 
            this.menuToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemWyszukajAutomatycznie});
            this.menuToolStripMenuItem1.Name = "menuToolStripMenuItem1";
            this.menuToolStripMenuItem1.Size = new System.Drawing.Size(50, 20);
            this.menuToolStripMenuItem1.Text = "Menu";
            // 
            // toolStripMenuItemWyszukajAutomatycznie
            // 
            this.toolStripMenuItemWyszukajAutomatycznie.Name = "toolStripMenuItemWyszukajAutomatycznie";
            this.toolStripMenuItemWyszukajAutomatycznie.Size = new System.Drawing.Size(195, 22);
            this.toolStripMenuItemWyszukajAutomatycznie.Text = "Wyszukaj po włączeniu";
            this.toolStripMenuItemWyszukajAutomatycznie.Click += new System.EventHandler(this.zaznaczObiektMenu);
            this.toolStripMenuItemWyszukajAutomatycznie.DoubleClick += new System.EventHandler(this.zaznaczObiektMenu);
            // 
            // AddRemotePrinters
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(544, 696);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.buttonZainstalujDrukarki);
            this.Controls.Add(this.checkedListBoxKomputery);
            this.Controls.Add(this.checkedListBoxPrinters);
            this.Controls.Add(this.buttonWyszukajKomputery);
            this.Controls.Add(this.textBoxNazwaDomeny);
            this.Controls.Add(this.buttonWyszukajDrukarki);
            this.Controls.Add(this.textBoxSerwerWydruku);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.menuStrip2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MainMenuStrip = this.menuStrip2;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddRemotePrinters";
            this.Text = "ARPrinters";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AddRemotePrinters_Closing);
            this.Load += new System.EventHandler(this.AddRemotePrinters_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxSerwerWydruku;
        private System.Windows.Forms.Button buttonWyszukajDrukarki;
        private System.Windows.Forms.Button buttonWyszukajKomputery;
        private System.Windows.Forms.TextBox textBoxNazwaDomeny;
        private System.Windows.Forms.CheckedListBox checkedListBoxPrinters;
        private System.Windows.Forms.CheckedListBox checkedListBoxKomputery;
        private System.Windows.Forms.Button buttonZainstalujDrukarki;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private System.Windows.Forms.RadioButton radioButtonDodajDrukarke;
        private System.Windows.Forms.RadioButton radioButtonUsunDrukarke;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemWyszukajAutomatycznie;
    }
}

