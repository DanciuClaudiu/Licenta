using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Licenta.Models
{
    public class LicentaContext : DbContext
    {
        public LicentaContext (DbContextOptions<LicentaContext> options)
            : base(options)
        {
        }

        public DbSet<Licenta.Models.User> User { get; set; }
        public DbSet<Licenta.Models.Instrument> Instrument { get; set; }
    }
}
