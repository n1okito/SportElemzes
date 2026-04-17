using System;
using System.Data.Entity;
using System.Windows.Forms;
using SportElemzes.Adatbazis;

namespace SportElemzes
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            try
            {
                AppDomain.CurrentDomain.SetData("DataDirectory", Application.StartupPath);

                Database.SetInitializer(new SportAdatbazisInicializalo());

                using (var db = new SportAdatbazis())
                {
                    db.Database.Initialize(false);
                }

                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);

                using (var loginForm = new BejelentkezesForm())
                {
                    if (loginForm.ShowDialog() == DialogResult.OK)
                    {
                        Application.Run(new Form1());
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Indítási hiba");
            }
        }
    }
}