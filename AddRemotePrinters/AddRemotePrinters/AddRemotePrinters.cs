using Properties = ARPrinters.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using Settings = ARPrinters.Properties.Settings;
using System.DirectoryServices;
using System.Windows.Forms;

namespace AddRemotePrinters
{
    public partial class AddRemotePrinters : Form
    {
        FormBorderStyle a = FormBorderStyle.None;
        Drukarka printer = new Drukarka();
        Domena domena = new Domena();
        List<string> drukarkiPosortowane, komputery = new List<string>();
        
        public bool Checked { get; private set; }

        //AddRemotePrinters arp = new AddRemotePrinters();
        public AddRemotePrinters()
        {
            InitializeComponent();
            textBoxNazwaDomeny.Text = domena.NazwaDomeny;
            textBoxSerwerWydruku.Text = Properties.Settings.Default.OstatniaNazwaSerweraWydruku;
            //userNameBox.Text = Properties.Settings.Default.OstatniaNazwaUzytkownikaLogowania;
            backgroundWorker1.WorkerReportsProgress = true;
            backgroundWorker1.WorkerSupportsCancellation = true;
            radioButtonDodajDrukarke.Checked = true;
            //sprawdzenie zaznaczona jest opcja automatycznego wyszukania przy uruchomieniu 
            //Jeżeli PRAWDA wyszukaj drukarki i komputery
            ((ToolStripMenuItem)toolStripMenuItemWyszukajAutomatycznie).Checked = Settings.Default.AutomatyczneWyszukiwanie;//ustawia zapisana wartość bool dla wyszukiwania automatycznego
            if (((ToolStripMenuItem)toolStripMenuItemWyszukajAutomatycznie).Checked)
            {
                buttonWyszukajDrukarki_Click(null, null);
                buttonWyszukajKomputery_Click(null, null);
            }
        }

        private void zaznaczObiektMenu(object sender, EventArgs e)
            {
            ToolStripMenuItem item = (ToolStripMenuItem)sender;
            if(item.Checked)
            {if(item.Name.Equals("toolStripMenuItemWyszukajAutomatycznie"))
                { Settings.Default.AutomatyczneWyszukiwanie = true;
                    Settings.Default.Save();
                }
                item.Checked = false; }
            else
            {
                if (item.Name.Equals("toolStripMenuItemWyszukajAutomatycznie"))
                { Settings.Default.AutomatyczneWyszukiwanie = false;
                    Settings.Default.Save();
                }
                item.Checked = true; }
            
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        // This event handler is where the time-consuming work is done.
        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            BackgroundWorker worker = sender as BackgroundWorker;

            string nazwaSerweraWydruku = textBoxSerwerWydruku.Text.ToString();
            if (String.IsNullOrEmpty(nazwaSerweraWydruku))
            {
                MessageBox.Show("Brak nazwy serwera wydruku");

            }
            else
            {


              
                    drukarkiPosortowane = printer.PobierzDrukarki(nazwaSerweraWydruku);

                    if (drukarkiPosortowane != null)
                    {
                        if (InvokeRequired)
                        {
                            //checkedListBoxPrinters.BeginInvoke(checkedListBoxPrinters.Items.Clear());
                            foreach (string drukarka in drukarkiPosortowane)
                            {
                               

                               Invoke(new Action(()=> checkedListBoxPrinters.Items.Add(drukarka)));
                            }
                        }
                    }
                
                


                
            }
          
         }

        private void buttonWyszukajDrukarki_Click(object sender, EventArgs e)
        {
            if (!backgroundWorker1.IsBusy)
            {
                checkedListBoxPrinters.Items.Clear();

                backgroundWorker1.RunWorkerAsync();
            }
            }
        
        private void buttonWyszukajKomputery_Click(object sender, EventArgs e)
        {
            if (!backgroundWorker1.IsBusy)
            {
                checkedListBoxKomputery.Items.Clear();

                backgroundWorker2.RunWorkerAsync();
            }
        }

        private void backgroundWorker2_DoWork(object sender, DoWorkEventArgs e)
        {
            string nazwaDomeny = textBoxNazwaDomeny.Text.ToString();
            if (nazwaDomeny == "")
            {
                MessageBox.Show("Brak nazwy domeny");
             }
            else
            {

                komputery = domena.PobierzKomputery(nazwaDomeny);
                if (komputery != null)
                {
                   
                    foreach (string komputer in komputery)
                    {
                        Invoke(new Action(() => checkedListBoxKomputery.Items.Add(komputer.ToString())));
                    }
                }
            }
        }
       

        private void isChecked(object sender)
        {
            RadioButton radioButton = (RadioButton) sender;
     
            if (radioButton.Name.Equals("radioButtonDodajDrukarke"))
                {
                radioButtonUsunDrukarke.Checked = false;
                //radioButtonUsunDrukarkeLokalna.Checked = false;
            }
            else if (radioButton.Name.Equals("radioButtonUsunDrukarke"))
            {
                radioButtonDodajDrukarke.Checked = false;
                //radioButtonUsunDrukarkeLokalna.Checked = false;
            }
           

        }

        private void textBoxUrlPrintServer_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                buttonWyszukajDrukarki_Click(null,null);
            }
        }

        private void textBoxNazwaDomeny_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                buttonWyszukajKomputery_Click(null, null);
            }
        }

        private void buttonZainstalujDrukarki_Click(object sender, EventArgs e)
        {   Drukarka drukarka = new Drukarka();
             string parametr =null;
            string parametrSerwerWydruku = textBoxSerwerWydruku.Text;
           if (radioButtonDodajDrukarke.Checked == true)
            { parametr = @"/ga "; }
                    else if(radioButtonUsunDrukarke.Checked == true)
            { parametr = @"/gd "; }
          
            
            foreach (String checkedItemPrinter in checkedListBoxPrinters.CheckedItems)
            {
                foreach (String checkedItemComputer in checkedListBoxKomputery.CheckedItems)
                {
                   
                    drukarka.DodajDrukarke(checkedItemComputer,checkedItemPrinter,parametr,parametrSerwerWydruku );

                }
            }
         
            
        }

        private void textBoxNazwaDomeny_TextChanged(object sender, EventArgs e)
        {
            try
            {
                TextBox box = (TextBox) sender;
                DirectoryEntry entry = new DirectoryEntry("LDAP://" + box.Text.ToString());
                DirectorySearcher mySearcher = new DirectorySearcher(entry);
                mySearcher.Asynchronous = true;
                SearchResultCollection res = mySearcher.FindAll();
                MessageBox.Show(res.Count.ToString());
                AutoCompleteStringCollection namecollection = new AutoCompleteStringCollection();

                
     
                if (entry.Children != null)
                {
                    foreach (DirectoryEntry a in entry.Children)
                    {
                        namecollection.Add(a.ToString());
                    }

                    textBoxNazwaDomeny.AutoCompleteMode = AutoCompleteMode.Suggest;
                    textBoxNazwaDomeny.AutoCompleteSource = AutoCompleteSource.CustomSource;
                    textBoxNazwaDomeny.AutoCompleteCustomSource = namecollection;
                } }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void AddRemotePrinters_Load(object sender, EventArgs e)
        {

        }

        private void AddRemotePrinters_Closing(object sender, FormClosingEventArgs e)
        {
            
            Settings.Default.OstatniaNazwaSerweraWydruku = textBoxSerwerWydruku.Text;
          //  Settings.Default.OstatniaNazwaUzytkownikaLogowania = userNameBox.Text;
            Settings.Default.Save();
          

        }
    }
  }

