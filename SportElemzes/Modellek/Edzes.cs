using System;

namespace SportElemzes.Modellek
{
    
    public class Edzes
    {
        
        public int Id { get; set; }       
        public int SportoloId { get; set; }
        public DateTime Datum { get; set; }                  
        public string Edzestipus { get; set; } = "";

       
        public int Rpe { get; set; }

        
        public int IdotartamPercben { get; set; }

        /// <summary>
        /// összterhelés kiszámolása, MÉG NEM JÓ . MEG KELL CSINÁLNI!!!!!!!!!!!!!!
        /// </summary>
        public int Terheles => Rpe * IdotartamPercben;
    }
}
