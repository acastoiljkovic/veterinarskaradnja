using System;
using System.Windows.Forms;

namespace VeterinarskaRadnja
{
    public partial class AddLjubimacForm : Form
    {
        public AddLjubimacForm()
        {
            InitializeComponent();
        }
        private DataLayer.Models.Ljubimac generateLjubimac()
        {
            DataLayer.Models.Ljubimac ljubimac = new DataLayer.Models.Ljubimac();

            if (txtNaziv.Text != "")
                ljubimac.Ime = txtNaziv.Text;
            else
                return null;
            if (cbTip.SelectedItem.ToString() != "")
                ljubimac.Tip = cbTip.SelectedItem.ToString();
            else
                return null;
            if (dtpDatumRodjenja.Value != null)
                ljubimac.DatumRodjenja = dtpDatumRodjenja.Value.Date;

            return ljubimac;
        }
        private void btnDodaj_Click(object sender, EventArgs e)
        {
            if (generateLjubimac() != null)
            {
                if (DataLayer.DbManager.getInstance().dodajLjubimca(generateLjubimac()))
                {
                    MessageBox.Show("Uspesno dodat ljubimac !");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Greska prilikom dodavanja ljubimca !");
                }
            }
            else
            {
                MessageBox.Show("Pogresno uneti podaci. Molimo Vas popunite sva polja !");
            }
        }
    }
}
