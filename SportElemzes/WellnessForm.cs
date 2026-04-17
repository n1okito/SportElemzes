using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SportElemzes
{
    public partial class WellnessForm : Form
    {
        public WellnessForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnWellnessFelvitel_Click(object sender, EventArgs e)
        {
            using (var form = new WellnessFelvitelForm())
            {
                if (form.ShowDialog() == DialogResult.OK)
                {

                }
            }

        }

        private void btnMegse_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnWellness_Click(object sender, EventArgs e)
        {
            using (var form = new WellnessListaForm())
            {
                form.ShowDialog(this);
            }
        }

        private void btnWellnessLista_Click(object sender, EventArgs e)
        {
            using (var form = new WellnessListaForm())
            {
                form.ShowDialog(this);
            }
        }

        private void btnWellnessElemzes_Click(object sender, EventArgs e)
        {
            using (var form = new WellnessElemzesForm())
            {
                form.ShowDialog(this);
            }
        }
    }
}

    
