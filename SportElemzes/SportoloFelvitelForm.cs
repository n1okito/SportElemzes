using System;
using System.Windows.Forms;

namespace SportElemzes
{
    public partial class SportoloFelvitelForm : Form
    {
        public SportoloFelvitelForm()
        {
            InitializeComponent();
        }
       
        public string SportoloNev
        {
            get => txtNev.Text;
            set => txtNev.Text = value;
        }

        public DateTime SzuletesiDatum
        {
            get => dtpSzuletesiDatum.Value.Date;
            set => dtpSzuletesiDatum.Value = value;
        }

        public string SportoloPoszt
        {
            get => txtPoszt.Text;
            set => txtPoszt.Text = value;
        }
        public bool SportoloAktiv
        {
            get => chkAktiv.Checked;
            set => chkAktiv.Checked = value;
        }
        private void btnMentes_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNev.Text))
            {
                MessageBox.Show("A név megadása kötelező.", "Hiba",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                DialogResult = DialogResult.None; // ne záródjon be
                return;
            }

            DialogResult = DialogResult.OK;
            Close();
        }

        private void btnMegsem_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void dtpSzuletesiDatum_ValueChanged(object sender, EventArgs e)
        {
            
        }
        private void SportoloFelvitelForm_Load(object sender, EventArgs e)
        {

        }
        private void label4_Click(object sender, EventArgs e)
        {

        }
        private void btnBezar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void chkAktiv_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
