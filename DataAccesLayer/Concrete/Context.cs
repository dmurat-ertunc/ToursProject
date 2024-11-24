using EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccesLayer.Concrete
{
    public class Context : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-5DBEE0D\\SQLEXPRESS;Database=ToursDb;Trusted_Connection=True;TrustServerCertificate=True");
            //optionsBuilder.UseSqlServer("Server=DESKTOP-O24BTL3\\SQLEXPRESS;Database=ToursDb;Trusted_Connection=True;TrustServerCertificate=True");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

        }
        public DbSet<Cities> TblCities { get; set; }
        public DbSet<Comments> TblComments { get; set; }
        public DbSet<Contact> TblContact { get; set; }
        public DbSet<Services> TblServices { get; set; }
        public DbSet<SocialMedia> TblSocialMedia { get; set; }
        public DbSet<Stations> TblStations { get; set; }
        public DbSet<TicketSold> TblTicketSold { get; set; }
        public DbSet<Tours> TblTours { get; set; }
        public DbSet<TourTime> TblTourTime { get; set; }


    }
}
