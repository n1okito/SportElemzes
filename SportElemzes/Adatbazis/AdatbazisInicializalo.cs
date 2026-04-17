using System.Data.Entity;

namespace SportElemzes.Adatbazis
{
    public class SportAdatbazisInicializalo : CreateDatabaseIfNotExists<SportAdatbazis>
    {
        protected override void Seed(SportAdatbazis context)
        {
            base.Seed(context);
        }
    }
}