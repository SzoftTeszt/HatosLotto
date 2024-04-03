using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.Data
{
    public class HatosContext :DbContext
    {
        public DbSet<ClassLibrary.Models.Jatekos> Jatekos { get; set; } = default!;

        public DbSet<ClassLibrary.Models.Tipp>? Tipp { get; set; }

        public HatosContext()
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string conn = "Server=(localdb)\\mssqllocaldb;Database=HatosApi.Data;Trusted_Connection=True;MultipleActiveResultSets=true";
            optionsBuilder.UseSqlServer(conn);
        }
    }
}
