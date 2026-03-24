using System;
using System.Linq;
using System.Windows.Forms;
using SportElemzes.Adatbazis;
using SportElemzes.Modellek;

namespace SportElemzes
{
    public partial class EdzesForm : Form
    {
        private readonly SportAdatbazis _adatbazis;
        private readonly Sportolo _sportolo;

        public EdzesForm(SportAdatbazis adatbazis, Sportolo sportolo)
        {
            InitializeComponent();
            _adatbazis = adatbazis;
            _sportolo = sportolo;
        }

        private void EdzesForm_Load(object sender, EventArgs e)
        {
            lblSportoloNev.Text = _sportolo.Nev;
            
            numRpe.Minimum = 1;
            numRpe.Maximum = 10;
            numRpe.Value = 5;

            numIdotartam.Minimum = 1;
            numIdotartam.Maximum = 600;
            numIdotartam.Value = 60;

            dtpDatum.Value = DateTime.Today;

            BetoltEdzesek();
        }    
        private void BetoltEdzesek()
        {
            var lista = _adatbazis.Edzesek
                .Where(e => e.SportoloId == _sportolo.Id)
                .OrderByDescending(e => e.Datum)
                .ToList();

            dgvEdzesek.DataSource = lista;
        }

        private void btnHozzaadas_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtEdzestipus.Text))
            {
                MessageBox.Show("Az edzés típusa kötelező.", "Hiba",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var ujEdzes = new Edzes
            {
                SportoloId = _sportolo.Id,
                Datum = dtpDatum.Value.Date,
                Edzestipus = txtEdzestipus.Text.Trim(),
                Rpe = (int)numRpe.Value,
                IdotartamPercben = (int)numIdotartam.Value
            };

            _adatbazis.Edzesek.Add(ujEdzes);
            _adatbazis.SaveChanges();

            BetoltEdzesek();
        }

        private Edzes KivalasztottEdzes()
        {
            if (dgvEdzesek.CurrentRow == null)
                return null;

            return dgvEdzesek.CurrentRow.DataBoundItem as Edzes;
        }

        private void btnEdzesTorles_Click(object sender, EventArgs e)
        {
            var edzes = KivalasztottEdzes();
            if (edzes == null)
            {
                MessageBox.Show("Nincs kiválasztott edzés.", "Figyelem",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var valasz = MessageBox.Show(
                $"Biztosan törölni szeretnéd a kijelölt edzést?\n\nDátum: {edzes.Datum:d}\nTípus: {edzes.Edzestipus}",
                "Edzés törlése",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (valasz == DialogResult.Yes)
            {
                _adatbazis.Edzesek.Remove(edzes);
                _adatbazis.SaveChanges();
                BetoltEdzesek();
            }
        }

        private void btnBezar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
