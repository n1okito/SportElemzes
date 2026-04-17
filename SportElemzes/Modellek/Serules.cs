using System;

namespace SportElemzes.Modellek
{
    
    public class Serules
    {
        public int Id { get; set; }
        public int SportoloId { get; set; }       
        public DateTime Kezdet { get; set; }       
        public DateTime? Vege { get; set; }        
        public string Tipus { get; set; } = "";       
        public string Leiras { get; set; } = "";
    }
}
