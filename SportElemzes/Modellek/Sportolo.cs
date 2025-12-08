using System;

namespace SportElemzes.Modellek
{
    /// <summary>
    /// adatok
    /// </summary>
    public class Sportolo
    {
        
        public int Id { get; set; }        
        public string Nev { get; set; } = "";        
        public DateTime SzuletesiDatum { get; set; }       
        public string Poszt { get; set; } = "";       
        public bool Aktiv { get; set; } = true;
    }
}
