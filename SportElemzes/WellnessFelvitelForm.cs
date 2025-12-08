using System;
using System.Linq;
using System.Windows.Forms;
using SportElemzes.Adatbazis;
using SportElemzes.Modellek;

namespace SportElemzes
{
    public partial class WellnessFelvitelForm : Form
    {
        private readonly SportAdatbazis _db = new SportAdatbazis();

        public WellnessFelvitelForm()
        {
            InitializeComponent();
        }

        private void WellnessFelvitelForm_Load(object sender, EventArgs e)
        {
            cmbSportolo.DataSource = _db.Sportolok.OrderBy(s => s.Nev).ToList();
            cmbSportolo.DisplayMember = "Nev";
            cmbSportolo.ValueMember = "Id";
            dtpDatum.Value = DateTime.Today;
        }

        private void btnMentes_Click(object sender, EventArgs e)
        {
            if (cmbSportolo.SelectedValue == null)
                return;

            var bejegyzes = new WellnessBejegyzes
            {
                SportoloId = (int)cmbSportolo.SelectedValue,
                Datum = dtpDatum.Value.Date,
                AlvasOra = double.Parse(txtAlvas.Text),
                AlvasMinoseg = (int)numAlvasMinoseg.Value,
                Faradtsag = (int)numFaradtsag.Value,
                Izomlaz = (int)numIzomlaz.Value,
                Hangulat = (int)numHangulat.Value
            };

            _db.WellnessBejegyzesek.Add(bejegyzes);
            _db.SaveChanges();

            DialogResult = DialogResult.OK;
            Close();
        }

        private void btnMegse_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            _db.Dispose();
            base.OnFormClosed(e);
        }
    }
}
