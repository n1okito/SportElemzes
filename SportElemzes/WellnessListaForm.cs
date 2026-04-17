using System;
using System.Linq;
using System.Windows.Forms;
using SportElemzes.Adatbazis;

namespace SportElemzes
{
    public partial class WellnessListaForm : Form
    {
        private readonly SportAdatbazis _adatbazis = new SportAdatbazis();

        public WellnessListaForm()
        {
            InitializeComponent();
        }

        private void WellnessListaForm_Load(object sender, EventArgs e)
        {
            var sportolok = _adatbazis.Sportolok
                .OrderBy(s => s.Nev)
                .ToList();

            cmbSportolo.DisplayMember = "Nev";
            cmbSportolo.ValueMember = "Id";
            cmbSportolo.DataSource = sportolok;

            BetoltWellness();
        }

        private void btnFrissit_Click(object sender, EventArgs e)
        {
            BetoltWellness();
        }

        private void btnMegse_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BetoltWellness()
        {
            if (cmbSportolo.SelectedValue == null)
                return;

            int sportoloId = (int)cmbSportolo.SelectedValue;

            var lista = _adatbazis.WellnessBejegyzesek
                .Where(w => w.SportoloId == sportoloId)
                .OrderByDescending(w => w.Datum)
                .ToList();

            dgvWellness.DataSource = lista;
        }

        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            _adatbazis.Dispose();
            base.OnFormClosed(e);
        }
    }
}
