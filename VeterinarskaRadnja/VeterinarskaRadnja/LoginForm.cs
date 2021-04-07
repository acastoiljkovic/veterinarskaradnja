using System;
using System.Windows.Forms;

namespace VeterinarskaRadnja
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnPrijava_Click(object sender, EventArgs e)
        {
            // provera da li je uopste nesto uneto u text box-eve
            if (txtEmail.Text != "" && txtLozinka.Text != "")
            {
                // pozivamo metodu iz DbManager klase koja vrsi logovanje korisnika
                if (DataLayer.DbManager.getInstance().ulogujKorisnika(txtEmail.Text, txtLozinka.Text))
                {
                    Form app = new AppForm();
                    app.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Pogresna email adresa ili lozinka !");
                }

            }
            else
            {
                MessageBox.Show("Molimo Vas unesite email adresu i lozinku!");
            }
        }
    }
}
