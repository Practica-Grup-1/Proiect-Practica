using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace Proiect
{

    public partial class FormAngajat : Form
    {
        public float salmin =9999999, salmax=0, salmediu=0;
        public void Calculare(ref float cas, ref float cass, ref float impozit,ref float salariuNet , Angajat ang)
        {
            cas = 0.25f * ang.salariuBrut;
            cass = 0.1f * ang.salariuBrut;
            salariuNet = ang.salariuBrut - cas - cass;
            if (ang.scutitImpozit == true)
                impozit = 0;
            else
            {
                impozit = 0.1f * salariuNet;
                salariuNet = salariuNet - impozit;
            }
        }

        public FormAngajat()
        {
            InitializeComponent();

            
           
            Angajat angajat1 = new Angajat("Ionescu", "Alexandru", "1247892341256","Manager" , 234.2f, true);

            ListViewItem aux = new ListViewItem(angajat1.nume);
            aux.SubItems.Add(angajat1.prenume);
            aux.SubItems.Add(angajat1.CNP);
            aux.SubItems.Add(angajat1.functie);
            aux.SubItems.Add(angajat1.salariuBrut.ToString());
            if(angajat1.scutitImpozit==true)
            aux.SubItems.Add("Da");
            else
                aux.SubItems.Add("Nu");
            aux.Tag = angajat1;
            listViewAngajat.Items.Add(aux);
        }

        public void UpdateItems()
        {
            foreach(ListViewItem lvi in listViewAngajat.Items)
            {
                Angajat a = (Angajat)lvi.Tag;
                lvi.Text = a.nume;
                lvi.SubItems[1].Text = a.prenume;
                lvi.SubItems[2].Text = a.CNP;
                lvi.SubItems[3].Text = a.functie;
                lvi.SubItems[4].Text = a.salariuBrut.ToString();
                if (a.scutitImpozit == true)
                    lvi.SubItems[5].Text = "Da";
                else
                    lvi.SubItems[5].Text = "Nu";
            }
            CalcSalMin(ref salmin, ref salmax, ref salmediu);

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            BackColor = Color.CornflowerBlue;
        }

        private void listViewAngajat_SelectedIndexChanged(object sender, EventArgs e)
        {
          
        }

        private void modificaSalariatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (listViewAngajat.SelectedItems.Count > 0)
            {
                Forma2 fm = new Forma2();

                listViewAngajat.SelectedIndexChanged += new EventHandler(fm.ActualizeazaControale);

                fm.Text = "Modificare angajat";

                fm.ActualizeazaControale(listViewAngajat, e);
                fm.form = this;

                fm.ShowDialog();
            }
        }

        
        private void stergeSalariatToolStripMenuItem_Click(object sender, EventArgs e)
        {        
                if (listViewAngajat.SelectedItems.Count > 0)
                {
                    Angajat a = (Angajat)listViewAngajat.SelectedItems[0].Tag;
                    DialogResult delete = MessageBox.Show("Stergeti angajatul cu numele  " + a.nume + " ?",
                        "Apasati yes pentru a sterge", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                    if (delete == DialogResult.Yes) listViewAngajat.SelectedItems[0].Remove();   
            }
        }

        private void adaugaSalariatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListViewItem lvi = new ListViewItem(new string[] { "", "", "", "", "", "" });
            listViewAngajat.Items.Add(lvi);
            Angajat a = new Angajat("", "", "", " ", 0, false);
            lvi.Tag = a;
            lvi.Selected = true;

            Forma2 f2 = new Forma2();
            f2.angajat = a;
            f2.form = this;
            f2.Text = "Adauga angajat";
            f2.buttonActualizare.Text = "Adauga";

            f2.ShowDialog();
            if (f2.DialogResult != DialogResult.OK) lvi.Remove();//daca nu apesi pe buton nu ti adauga medicul
        }

        private void printeazaFluturasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MemoryStream memStream = new MemoryStream();
            XmlTextWriter writer = new XmlTextWriter(memStream, Encoding.UTF8);
            writer.Formatting = Formatting.Indented;

            Angajat a = (Angajat)listViewAngajat.SelectedItems[0].Tag;
            float cas = 0;
            float cass = 0;
            float impozit = 0;
            float salariuNet = 0;
            Calculare(ref cas,ref cass,ref impozit,ref salariuNet, a);
            writer.WriteStartDocument();
            writer.WriteStartElement("Fluturas-salariu");

            
                writer.WriteStartElement("Angajat");

                writer.WriteElementString("CNP", a.CNP);
                writer.WriteElementString("Nume", a.nume+" "+a.prenume);
                writer.WriteElementString("cas", cas.ToString());
                writer.WriteElementString("cass", cass.ToString());
                writer.WriteElementString("impozit", impozit.ToString());
                writer.WriteElementString("salariu net", salariuNet.ToString());
                writer.WriteEndElement();

            
                
            
                writer.WriteEndElement();
                writer.WriteEndDocument();
                writer.Close();
            

                string xmlstring = Encoding.UTF8.GetString(memStream.ToArray());

                memStream.Close();
                memStream.Dispose();

                StreamWriter sw = new StreamWriter("c:\\temp\\fisier.xml");
                sw.WriteLine(xmlstring);
                sw.Close();

                MessageBox.Show("Fisier generat cu succes");
            
        }

        private void afisareGraficToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CalcSalMin(ref salmin, ref salmax, ref salmediu);
            Form2 f2 = new Form2();
            f2.parinte = this;
            f2.Show();
        }

        private void adaugaAngajatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            adaugaAngajatToolStripMenuItem_Click(sender, e);
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {
            if (listViewAngajat.SelectedItems.Count > 0)
            {
                modificaAngajatToolStripMenuItem.Enabled = true;
                stergeAngajatToolStripMenuItem.Enabled = true;
            }
            else
            {
                modificaAngajatToolStripMenuItem.Enabled = false;
                stergeAngajatToolStripMenuItem.Enabled = false;
            }
        }

        private void printeazaFluturasCSVToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Angajat a = (Angajat)listViewAngajat.SelectedItems[0].Tag;
            
            salvareCSV(a.nume, a.prenume, a.CNP, a.functie, a.salariuBrut, a.scutitImpozit, "c:\\temp\\fisier.csv");

            MessageBox.Show("Fisier CSV generat cu succes!");
           
        }

        public static void salvareCSV(string nume, string prenume, string cnp, string functie, float salariu, bool scutire, string cale)
        {
            try
            {
                using(StreamWriter file = new StreamWriter(@cale, true))
                {
                    file.WriteLine(nume + "," + prenume + "," + cnp + "," + functie + "," + salariu + "," + scutire);
                }
            }catch(Exception ex)
            {
                throw new ApplicationException("Programul nu a functionat!", ex);
            }
        }

        private void editeazaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        public void CalcSalMin(ref float salmin,ref float salmax,ref float salmediu)
        {
            salmin = 9999999;
            salmax = 0;
            salmediu = 0;
            foreach(ListViewItem lvi in listViewAngajat.Items)
            {
                Angajat a = (Angajat)lvi.Tag;//fiecare item din list view are un tag. tag ul contine informatia despre un angajat. 
                if (a.salariuBrut < salmin) salmin = a.salariuBrut; 
                if (a.salariuBrut > salmax) salmax = a.salariuBrut;
                salmediu += a.salariuBrut;
            }
            salmediu = salmediu / listViewAngajat.Items.Count;
        }

        
    }
}
