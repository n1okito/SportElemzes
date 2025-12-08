using System;

namespace SportElemzes.Modellek
{
    /// <summary>
    /// még csak ötlet. Később megcsinálom
    /// </summary>
    public class WellnessBejegyzes
    {
        public int Id { get; set; }
        public int SportoloId { get; set; }
        public DateTime Datum { get; set; }        
        public double AlvasOra { get; set; }        
        public int AlvasMinoseg { get; set; }        
        public int Faradtsag { get; set; }        
        public int Izomlaz { get; set; }     
        public int Hangulat { get; set; }
    }
}
