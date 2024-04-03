using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.Models
{
    public class Jatekos
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Tipp> Tipp { get; } = new List<Tipp>();

        public Jatekos()
        {
        }

        public Jatekos(string sor)
        {
            string[] parts = sor.Split(";");
            Name = parts[0];
        }

        public override string? ToString()
        {
            string s = Name + ": ";
            foreach (var item in Tipp) s += item;            
            return s;
        }
    }
}
