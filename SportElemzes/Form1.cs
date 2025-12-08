using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using SportElemzes.Adatbazis;
using SportElemzes.Modellek;

namespace SportElemzes
{
    public partial class Form1 : Form
    {
        private readonly SportAdatbazis _adatbazis = new SportAdatbazis();

        public Form1()
        {
            InitializeComponent();
            this.DoubleBuffered = true;

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            BetoltSportolok();
        }        
        private void BetoltSportolok()
        {
            var lista = _adatbazis.Sportolok.ToList();
            dgvSportolok.DataSource = lista;
        }       
        private Sportolo KivalasztottSportolo()
        {
            if (dgvSportolok.CurrentRow == null)
                return null;

            return dgvSportolok.CurrentRow.DataBoundItem as Sportolo;
        }        
        private void btnUjSportolo_Click(object sender, EventArgs e)
        {
            using (var felvitelForm = new SportoloFelvitelForm())
            {
                if (felvitelForm.ShowDialog(this) == DialogResult.OK)
                {
                    
                    var ujSportolo = new Sportolo
                    {
                        Nev = felvitelForm.SportoloNev,
                        SzuletesiDatum = felvitelForm.SzuletesiDatum,
                        Poszt = felvitelForm.SportoloPoszt,
                        Aktiv = felvitelForm.SportoloAktiv
                    };

                    _adatbazis.Sportolok.Add(ujSportolo);
                    _adatbazis.SaveChanges();
                    BetoltSportolok();
                }
            }
        }

        
        private void btnModositas_Click(object sender, EventArgs e)
        {
            var sportolo = KivalasztottSportolo();
            if (sportolo == null)
            {
                MessageBox.Show("Nincs kiválasztott sportoló.", "Figyelem",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (var felvitelForm = new SportoloFelvitelForm())
            {
                
                felvitelForm.SportoloNev = sportolo.Nev;
                felvitelForm.SzuletesiDatum = sportolo.SzuletesiDatum;
                felvitelForm.SportoloPoszt = sportolo.Poszt;
                felvitelForm.SportoloAktiv = sportolo.Aktiv;

                if (felvitelForm.ShowDialog(this) == DialogResult.OK)
                {
                    
                    sportolo.Nev = felvitelForm.SportoloNev;
                    sportolo.SzuletesiDatum = felvitelForm.SzuletesiDatum;
                    sportolo.Poszt = felvitelForm.SportoloPoszt;
                    sportolo.Aktiv = felvitelForm.SportoloAktiv;

                    _adatbazis.SaveChanges();
                    BetoltSportolok();
                }
            }
        }        
        private void btnTorles_Click(object sender, EventArgs e)
        {
            var sportolo = KivalasztottSportolo();
            if (sportolo == null)
            {
                MessageBox.Show("Nincs kiválasztott sportoló.", "Figyelem",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var valasz = MessageBox.Show(
                $"Biztosan törölni szeretnéd a következő sportolót?\n\n{sportolo.Nev}",
                "Sportoló törlése",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (valasz == DialogResult.Yes)
            {
                _adatbazis.Sportolok.Remove(sportolo);
                _adatbazis.SaveChanges();
                BetoltSportolok();
            }
        }        
        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            _adatbazis.Dispose();
            base.OnFormClosed(e);
        }

        private void btnEdzesek_Click(object sender, EventArgs e)
        {
            var sportolo = KivalasztottSportolo();
            if (sportolo == null)
            {
                MessageBox.Show("Nincs kiválasztott sportoló.", "Figyelem",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (var form = new EdzesForm(_adatbazis, sportolo))
            {
                form.ShowDialog(this);
            }
        }
        private void btnElemzes_Click(object sender, EventArgs e)
        {
            using (var form = new ElemzesForm())
            {
                form.ShowDialog(this);
            }
        }

        private void btnGrafikon_Click(object sender, EventArgs e)
        {
            using (var form = new EdzesGrafikonForm())
            {
                form.ShowDialog(this);
            }
        }

        private void btnMegse_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBezar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnWellness_Click(object sender, EventArgs e)
        {
            using (var form = new WellnessForm())
            {
                if (form.ShowDialog() == DialogResult.OK)
                {
                    
                }
            }
        }
    }
    
}

    
