using SportElemzes.Modellek;
using System.Data.Entity;

public class SportAdatbazis : DbContext
{
    public SportAdatbazis() : base("name=SportAdatbazis")
    {
    }

    public DbSet<Sportolo> Sportolok { get; set; }
    public DbSet<Edzes> Edzesek { get; set; }
    public DbSet<WellnessBejegyzes> WellnessBejegyzesek { get; set; }
    public DbSet<Serules> Serulesek { get; set; }
    public DbSet<Felhasznalo> Felhasznalok { get; set; }
}
