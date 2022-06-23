using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Entities.Concrete;
using Entities.Concrete.Authentication;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.Extensions.Configuration;

namespace DataAccess.Concrete.EntitiyFramework.Contexts
{
    public class AppDbContext:IdentityDbContext<AppUser,AppRole,int>
    {
        public AppDbContext(DbContextOptions<AppDbContext> dbContext) : base(dbContext) { }

        public AppDbContext()
        {
            //throw new NotImplementedException();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
                "Server=(localdb)\\MSSQLLocalDB;initial catalog=ManBarberSalon;integrated security=true");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Reservation>()
                .Property(x => x.Date)
                .HasColumnType("date");


            modelBuilder.Entity<Reservation>()
                .Property(x => x.CanceledDate)
                .HasColumnType("smalldatetime");

            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Employee> Employees { get; set; }
        public DbSet<Reservation> Reservations { get; set; }

        public DbSet<Time> Times { get; set; }
        public DbSet<Menu> Menus { get; set; }

        public DbSet<Statu> Status { get; set; }
    }
}
