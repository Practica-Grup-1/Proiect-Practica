using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proiect
{
    public partial class Forma2 : Form
    {
        public Angajat angajat;
        public FormAngajat form;
        public Forma2()
        {
            InitializeComponent();    
        }

        private void Forma2_Load(object sender, EventArgs e)
        {
            BackColor = Color.CornflowerBlue;
        }

        public void ActualizeazaControale(object sender, EventArgs e)
        {
            ListView listamea = (ListView)sender;

            if (listamea.SelectedItems.Count > 0)
                angajat = (Angajat)listamea.SelectedItems[0].Tag;

            
            
                textBoxNume.Text = angajat.nume;
                textBoxPrenume.Text = angajat.prenume;
                textBoxCNP.Text = angajat.CNP;
                textBoxPozitie.Text = angajat.functie;
                textBoxSalariuBrut.Text = angajat.salariuBrut.ToString();
                if (angajat.scutitImpozit == true)
                    textBoxScutireImpozit.Text = "Da";
                else
                    textBoxScutireImpozit.Text = "Nu";
            
        }
        private void buttonActualizare_Click(object sender, EventArgs e)
        {
            bool eroareCNP = false;
            if (textBoxCNP.Text.Length != 13)
            {
                eroareCNP = true;
                errorProviderCNP.SetError(textBoxCNP, "Introduceti un CNP");
            }
            if (angajat != null && !eroareCNP)
            {
                this.DialogResult = DialogResult.OK;
                angajat.nume = textBoxNume.Text;
                angajat.CNP = textBoxCNP.Text;
                angajat.functie = textBoxPozitie.Text;
                angajat.prenume = textBoxPrenume.Text;
                angajat.salariuBrut = float.Parse(textBoxSalariuBrut.Text);
                if (textBoxScutireImpozit.Text == "Da")
                    angajat.scutitImpozit = true;
                else
                    angajat.scutitImpozit = false;
                form.UpdateItems();
            }
        }

        private void textBoxNume_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxNume_Validating(object sender, CancelEventArgs e)
        { if(textBoxNume.Text.Length<=2)
            {
                errorProvider1.SetError(textBoxNume, "Insuficiente caractere pentru nume");
                e.Cancel = true;

            }

        }

        private void textBoxNume_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(textBoxNume, "");
        }
    }
}
