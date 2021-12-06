using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WemaAppartments.Models
{
    public class WemaApartmentsContext:DbContext

    {
        public DbSet<WemaUsers> Users { get; set; }

        public DbSet<Tenants> Tenants { get; set; }
        public DbSet<Payments> Payments { get; set; }
        public DbSet<Apartment> Apartments { get; set; }
        public DbSet<Claims> Claims { get; set; }
        public DbSet <Repairs> Repairs { get; set; }
        public WemaApartmentsContext(DbContextOptions<WemaApartmentsContext> options) : base(options)
        {
        }

       
    }
}
