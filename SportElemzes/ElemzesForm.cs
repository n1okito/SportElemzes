using System;
using System.Linq;
using System.Windows.Forms;
using SportElemzes.Adatbazis;
using SportElemzes.Modellek;

namespace SportElemzes
{
    public partial class ElemzesForm : Form
    {
        private readonly SportAdatbazis _adatbazis = new SportAdatbazis();

        public ElemzesForm()
        {
            InitializeComponent();
        }

        private void ElemzesForm_Load(object sender, EventArgs e)
        {
            BetoltSportolok();
            dtpReferenciaDatum.Value = DateTime.Today;
        }

        private void BetoltSportolok()
        {
            var sportolok = _adatbazis.Sportolok
                .OrderBy(s => s.Nev)
                .ToList();

            cmbSportolo.DataSource = sportolok;
            cmbSportolo.DisplayMember = nameof(Sportolo.Nev);
            cmbSportolo.ValueMember = nameof(Sportolo.Id);
        }

        private void btnSzamitas_Click(object sender, EventArgs e)
        {
            if (cmbSportolo.SelectedValue == null)
            {
                MessageBox.Show("Nincs kiválasztott sportoló.", "Figyelem",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int sportoloId = (int)cmbSportolo.SelectedValue;
            DateTime referenciaDatum = dtpReferenciaDatum.Value.Date;

            var eredmeny = SzamolAcwr(sportoloId, referenciaDatum);

            lblAkut.Text = $"Akut terhelés (utolsó 7 nap átlaga): {eredmeny.AkutAtlag:F2}";
            lblKronikus.Text = $"Krónikus terhelés (utolsó 28 nap átlaga): {eredmeny.KronikusAtlag:F2}";
            lblAcwr.Text = $"ACWR (akut / krónikus): {eredmeny.Acwr:F2}";

            txtErtekeles.Text = GeneralErtekelesSzoveg(eredmeny.Acwr);
        }

        private (double AkutAtlag, double KronikusAtlag, double Acwr) SzamolAcwr(int sportoloId, DateTime referenciaDatum)
        {
            DateTime akutKezdet = referenciaDatum.AddDays(-6);   // utolsó 7 nap
            DateTime kronikusKezdet = referenciaDatum.AddDays(-27); // utolsó 28 nap

            var edzesek = _adatbazis.Edzesek
                .Where(e => e.SportoloId == sportoloId && e.Datum <= referenciaDatum)
                .ToList();

            double akutOsszTerheles = edzesek
                .Where(e => e.Datum >= akutKezdet)
                .Sum(e => (double)e.Terheles);

            double kronikusOsszTerheles = edzesek
                .Where(e => e.Datum >= kronikusKezdet)
                .Sum(e => (double)e.Terheles);

            double akutAtlag = akutOsszTerheles / 7.0;
            double kronikusAtlag = kronikusOsszTerheles / 28.0;

            double acwr = kronikusAtlag == 0 ? 0 : akutAtlag / kronikusAtlag;

            return (akutAtlag, kronikusAtlag, acwr);
        }

        private string GeneralErtekelesSzoveg(double acwr)
        {
            if (acwr == 0)
                return "Nem áll rendelkezésre elegendő adat az akut/krónikus terhelés és az ACWR kiszámításához.";

            if (acwr < 0.8)
                return $"Az ACWR értéke {acwr:F2}, amely alacsony terhelésre utal. Hosszabb távon ez teljesítménycsökkenést okozhat.";

            if (acwr <= 1.3)
                return $"Az ACWR értéke {acwr:F2}, amely az optimális terhelési tartományba esik.";

            if (acwr <= 1.5)
                return $"Az ACWR értéke {acwr:F2}, amely kissé emelkedett sérüléskockázatra utal. Érdemes óvatosan emelni a terhelést.";

            return $"Az ACWR értéke {acwr:F2}, amely fokozott sérüléskockázatra utal. Javasolt a terhelés csökkentése és a regenerációra való fokozott figyelem.";
        }

        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            _adatbazis.Dispose();
            base.OnFormClosed(e);
        }

        private void btnMegse_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBezar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtErtekeles_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
