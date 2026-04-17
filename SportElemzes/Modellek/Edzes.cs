using System;

namespace SportElemzes.Modellek
{
    
    public class Edzes
    {
        
        public int Id { get; set; }       
        public int SportoloId { get; set; }
        public DateTime Datum { get; set; }                  
        public string Edzestipus { get; set; } = "";
        
        /// Terhelés 1-10
        
        public int Rpe { get; set; }

        
        public int IdotartamPercben { get; set; }

        
        /// összterhelés kiszámolása, már műkszik
        
        public int Terheles => Rpe * IdotartamPercben;
    }
}
