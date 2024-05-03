using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace entity_framework_v2
{
    internal class HotelContext : DbContext
    {
        public DbSet<Client> Clients { get; set; }
        public DbSet<Reservation> Reservations { get; set; }
        public DbSet<Trip> Trips { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-P3R3LN8\\SQLEXPRESS;Database=Holydaydb;Trusted_Connection=True;TrustServerCertificate=true"); ;
        }
    }

}
