using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using SportElemzes.Adatbazis;
using SportElemzes.Modellek;
using System.Data.Entity;



namespace SportElemzes
{
    public partial class EdzesGrafikonForm : Form
    {
        private readonly SportAdatbazis _adatbazis = new SportAdatbazis();

        public EdzesGrafikonForm()
        {
            InitializeComponent();
        }

        private void EdzesGrafikonForm_Load(object sender, EventArgs e)
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

        private void BetoltGrafikon()
        {
            if (cmbSportolo.SelectedValue == null)
                return;

            int sportoloId = (int)cmbSportolo.SelectedValue;
            DateTime tol = dtpTol.Value.Date;
            DateTime ig = dtpIg.Value.Date;

            var adatok = _adatbazis.Edzesek
                .Where(e => e.SportoloId == sportoloId
                            && DbFunctions.TruncateTime(e.Datum) >= tol
                            && DbFunctions.TruncateTime(e.Datum) <= ig)
                .GroupBy(e => DbFunctions.TruncateTime(e.Datum))
                .Select(g => new
                {
                    Datum = g.Key.Value,                         
                    OsszTerheles = g.Sum(x => x.Rpe * x.IdotartamPercben)
                })
                .OrderBy(x => x.Datum)
                .ToList();

            chtTerheles.Series.Clear();
            chtTerheles.ChartAreas.Clear();

            var area = new ChartArea("Alap");
            chtTerheles.ChartAreas.Add(area);

            var series = new Series("Napi összterhelés");
            series.ChartType = SeriesChartType.Column;
            series.XValueType = ChartValueType.Date;

            foreach (var adat in adatok)
            {
                series.Points.AddXY(adat.Datum, adat.OsszTerheles);
            }

            chtTerheles.Series.Add(series);
            chtTerheles.ChartAreas[0].AxisX.LabelStyle.Format = "yyyy.MM.dd";
        }


        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            _adatbazis.Dispose();
            base.OnFormClosed(e);
        }

        private void chtTerheles_Click(object sender, EventArgs e)
        {

        }

        private void btnMegse_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

