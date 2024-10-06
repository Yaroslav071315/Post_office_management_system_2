using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Post_office_management_system_2.Models
{
    public class PostOfficeContext : DbContext
    {
        public DbSet<City> Cities { get; set; }
        public DbSet<Client> Clients { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<HeadPostOffice> HeadPostOffices { get; set; }
        public DbSet<Parcel> Parcels { get; set; }
        public DbSet<PostOffice> PostOffices { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySql("Server=Localhost;Database=post_office300924_db;User=root;Password=445566778899N;",
                new MySqlServerVersion(new Version(8, 3, 0)));
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Налаштування зв'язку для PostOfficeSend і PostOfficeCome
            modelBuilder.Entity<Parcel>()
                .HasOne(p => p.PostOfficeSend)
                .WithMany(po => po.Parcels)
                .HasForeignKey(p => p.PostOfficeId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Parcel>()
                .HasOne(p => p.PostOfficeCome)
                .WithMany()
                .HasForeignKey(p => p.PostOfficeId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }


}
