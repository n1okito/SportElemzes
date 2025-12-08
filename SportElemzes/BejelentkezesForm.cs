using System;
using System.Linq;
using System.Windows.Forms;
using SportElemzes.Adatbazis;
using SportElemzes.Modellek;

namespace SportElemzes
{
    public partial class BejelentkezesForm : Form
    {
        private readonly SportAdatbazis _adatbazis = new SportAdatbazis();

        public Felhasznalo BejelentkezettFelhasznalo { get; private set; }

        public BejelentkezesForm()
        {
            InitializeComponent();
        }

        private void btnBejelentkezes_Click(object sender, EventArgs e)
        {
            string felhasznalonev = txtFelhasznalonev.Text.Trim();
            string jelszo = txtJelszo.Text;

            var felhasznalo = _adatbazis.Felhasznalok
                .FirstOrDefault(f => f.Felhasznalonev == felhasznalonev);

            if (felhasznalo == null ||
                !JelszoKezelo.Ellenoriz(jelszo, felhasznalo.JelszoHash))
            {
                MessageBox.Show("Hibás felhasználónév vagy jelszó.",
                    "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            BejelentkezettFelhasznalo = felhasznalo;
            DialogResult = DialogResult.OK;
            Close();
        }

        private void btnRegisztracio_Click(object sender, EventArgs e)
        {
            using (var reg = new RegisztracioForm())
            {
                reg.ShowDialog(this);
            }
        }

        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            _adatbazis.Dispose();
            base.OnFormClosed(e);
        }

        private void btnBezar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
