using System;
using System.Windows.Forms;

namespace VeterinarskaRadnja
{
    public partial class AppForm : Form
    {
        public AppForm()
        {
            InitializeComponent();
            prikaziIme();
            enableItemsForAdmin();
        }

        private void prikaziIme()
        {
            lblName.Text = DataLayer.DbManager.getInstance().getUlogovanKorisnik().Ime + " " +
                DataLayer.DbManager.getInstance().getUlogovanKorisnik().Prezime;
        }

        private void enableItemsForAdmin()
        {
            if (DataLayer.DbManager.getInstance().getUlogovanKorisnik().Tip == "administrator")
            {
                txtImeKorisnika.Enabled = true;
                txtNazivRadnje.Enabled = true;
                btnPretrazi.Enabled = true;
                tsmiDodajLjubimca.Enabled = true;
            }
            else
            {
                dataGridViewPodaci.DataSource = DataLayer.DbManager.getInstance().getBrojKorisnika();
            }
        }

        private void btnPretrazi_Click(object sender, EventArgs e)
        {
            if (txtNazivRadnje.Text != "" && txtImeKorisnika.Text != "")
                MessageBox.Show("Molimo Vas popunite samo jedno od gore navedenih polja !");
            else if(txtNazivRadnje.Text != "")
                dataGridViewPodaci.DataSource = DataLayer.DbManager.getInstance()
                    .getSveKorisnikeVeterinarskeRadnje(txtNazivRadnje.Text);
            else if (txtImeKorisnika.Text != "")
                dataGridViewPodaci.DataSource = DataLayer.DbManager.getInstance()
                    .getLjubimacForKorisnik(txtImeKorisnika.Text);
            else
                MessageBox.Show("Molimo Vas popunite jedno od gore navedenih polja !");
        }

        private void aboutToolStripMenuButton_Click(object sender, EventArgs e)
        {
            // otvaramo formu AboutForm, ali ne zatvaramo postojecu, zelimo da ostane
            // u pozadini
            Form about = new AboutForm();
            about.Show();
        }

        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void tsmiDodajLjubimca_Click(object sender, EventArgs e)
        {
            Form about = new AddLjubimacForm();
            about.Show();
        }
    }
}
