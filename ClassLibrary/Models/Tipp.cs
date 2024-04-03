using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.Models
{
    public class Tipp
    {
        public Tipp()
        {
        }

        public Tipp(string sor)
        {
            string[] parts = sor.Split(";");
            JatekosId = Convert.ToInt32(parts[0]);
            Sz1 = Convert.ToInt32(parts[1]);
            Sz2 = Convert.ToInt32(parts[2]);
            Sz3 = Convert.ToInt32(parts[3]);
            Sz4 = Convert.ToInt32(parts[4]);
            Sz5 = Convert.ToInt32(parts[5]);
            Sz6 = Convert.ToInt32(parts[6]);
        }

        public override string? ToString()
        {
            return $"({Sz1};{Sz2};{Sz3};{Sz4};{Sz5};{Sz6}) ";
        }

        public int Id { get; set; }
        public int JatekosId { get; set; }
        public int Sz1 { get; set; }
        public int Sz2 { get; set; }
        public int Sz3 { get; set; }
        public int Sz4 { get; set; }
        public int Sz5 { get; set; }
        public int Sz6 { get; set; }        
    
    }
}
