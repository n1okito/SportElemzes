using System;
using System.Linq;
using System.Windows.Forms;
using SportElemzes.Adatbazis;
using SportElemzes.Modellek;

namespace SportElemzes
{
    public partial class RegisztracioForm : Form
    {
        private readonly SportAdatbazis _adatbazis = new SportAdatbazis();

        public RegisztracioForm()
        {
            InitializeComponent();
        }

        private void btnRegisztral_Click(object sender, EventArgs e)
        {
            string felhasznalonev = txtFelhasznalonev.Text.Trim();
            string jelszo = txtJelszo.Text.Trim();
            string jelszoMegerosites = txtJelszoMegerosites.Text.Trim();
            string teljesNev = txtTeljesNev.Text.Trim();

            
            if (string.IsNullOrWhiteSpace(felhasznalonev) ||
                string.IsNullOrWhiteSpace(jelszo) ||
                string.IsNullOrWhiteSpace(jelszoMegerosites))
            {
                MessageBox.Show("A felhasználónév és a jelszó megadása kötelező.",
                    "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            
            if (!string.Equals(jelszo, jelszoMegerosites))
            {
                MessageBox.Show("A két jelszó nem egyezik! (Trimelve is összehasonlítva)",
                    "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            
            bool letezik = _adatbazis.Felhasznalok
                .Any(f => f.Felhasznalonev == felhasznalonev);

            if (letezik)
            {
                MessageBox.Show("Ez a felhasználónév már foglalt.",
                    "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            
            var felhasznalo = new Felhasznalo
            {
                Felhasznalonev = felhasznalonev,
                JelszoHash = JelszoKezelo.KeszitHash(jelszo),
                TeljesNev = teljesNev,
                Szerep = "Edző"
            };

            _adatbazis.Felhasznalok.Add(felhasznalo);
            _adatbazis.SaveChanges();

            MessageBox.Show("Sikeres regisztráció! Most már bejelentkezhetsz.",
                "Kész", MessageBoxButtons.OK, MessageBoxIcon.Information);

            DialogResult = DialogResult.OK;
            Close();
        }

        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            _adatbazis.Dispose();
            base.OnFormClosed(e);
        }

        private void RegisztracioForm_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lblfelhasznalonev_Click(object sender, EventArgs e)
        {

        }

        private void lblTeljesNev_Click(object sender, EventArgs e)
        {

        }

        private void lblJelszoMegerosites_Click(object sender, EventArgs e)
        {

        }

        private void lblJelszo_Click(object sender, EventArgs e)
        {

        }

        private void btnMegse_Click(object sender, EventArgs e)
        {

        }

        private void btnBezar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtTeljesNev_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
