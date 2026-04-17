using System;
using System.Linq;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using SportElemzes.Adatbazis;

namespace SportElemzes
{
    public partial class WellnessElemzesForm : Form
    {
        private readonly SportAdatbazis _adatbazis = new SportAdatbazis();

        public WellnessElemzesForm()
        {
            InitializeComponent();
        }

        private void WellnessElemzesForm_Load(object sender, EventArgs e)
        {
            var sportolok = _adatbazis.Sportolok
                .OrderBy(s => s.Nev)
                .ToList();

            cmbSportolo.DisplayMember = "Nev";
            cmbSportolo.ValueMember = "Id";
            cmbSportolo.DataSource = sportolok;

            dtpIg.Value = DateTime.Today;
            dtpTol.Value = DateTime.Today.AddDays(-30);

            BetoltGrafikon();
        }

        private void btnFrissit_Click(object sender, EventArgs e)
        {
            BetoltGrafikon();
        }
        private void btnMegse_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BetoltGrafikon()
        {
            if (cmbSportolo.SelectedValue == null)
                return;

            int sportoloId = (int)cmbSportolo.SelectedValue;
            DateTime tol = dtpTol.Value.Date;
            DateTime ig = dtpIg.Value.Date;

            var adatok = _adatbazis.WellnessBejegyzesek
                .Where(w => w.SportoloId == sportoloId
                            && w.Datum >= tol
                            && w.Datum <= ig)
                .OrderBy(w => w.Datum)
                .ToList();

            chtWellness.Series.Clear();
            chtWellness.ChartAreas.Clear();

            var area = new ChartArea("Alap");
            area.AxisX.LabelStyle.Format = "yyyy.MM.dd";
            chtWellness.ChartAreas.Add(area);

            var alvasSeries = new Series("Alvás (óra)");
            alvasSeries.ChartType = SeriesChartType.Line;
            alvasSeries.XValueType = ChartValueType.Date;

            var faradtsagSeries = new Series("Fáradtság");
            faradtsagSeries.ChartType = SeriesChartType.Line;
            faradtsagSeries.XValueType = ChartValueType.Date;

            var izomlazSeries = new Series("Izomláz");
            izomlazSeries.ChartType = SeriesChartType.Line;
            izomlazSeries.XValueType = ChartValueType.Date;

            var hangulatSeries = new Series("Hangulat");
            hangulatSeries.ChartType = SeriesChartType.Line;
            hangulatSeries.XValueType = ChartValueType.Date;

            foreach (var adat in adatok)
            {
                alvasSeries.Points.AddXY(adat.Datum, adat.AlvasOra);
                faradtsagSeries.Points.AddXY(adat.Datum, adat.Faradtsag);
                izomlazSeries.Points.AddXY(adat.Datum, adat.Izomlaz);
                hangulatSeries.Points.AddXY(adat.Datum, adat.Hangulat);
            }

            chtWellness.Series.Add(alvasSeries);
            chtWellness.Series.Add(faradtsagSeries);
            chtWellness.Series.Add(izomlazSeries);
            chtWellness.Series.Add(hangulatSeries);
        }

        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            _adatbazis.Dispose();
            base.OnFormClosed(e);
        }
    }
}
