using System;
using System.Windows.Forms;
using SportElemzes.Adatbazis;

namespace SportElemzes
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            using (var loginForm = new BejelentkezesForm())
            {
                if (loginForm.ShowDialog() == DialogResult.OK)
                {
                    Application.Run(new Form1());
                }
                else
                {
                    return;
                }
            }
        }
    }
}
