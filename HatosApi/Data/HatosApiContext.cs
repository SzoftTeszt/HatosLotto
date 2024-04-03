using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ClassLibrary.Models;

namespace HatosApi.Data
{
    public class HatosApiContext : DbContext
    {
        public HatosApiContext (DbContextOptions<HatosApiContext> options)
            : base(options)
        {
        }

        public DbSet<ClassLibrary.Models.Jatekos> Jatekos { get; set; } = default!;

        public DbSet<ClassLibrary.Models.Tipp>? Tipp { get; set; }
    }
}
