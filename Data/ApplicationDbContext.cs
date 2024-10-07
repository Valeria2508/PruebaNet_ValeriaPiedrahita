using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using PruebaNet_ValeriaPiedrahita.Models;
using PruebaNet_ValeriaPiedrahita.Seeders;

namespace PruebaNet_ValeriaPiedrahita.Data
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Booking> Bookings { get; set; }
        public DbSet<Employee> Employees {get; set;}
        public DbSet<Guest> Guests { get; set; }
        public DbSet<Room> Rooms { get; set; }
        public DbSet<RoomType> RoomTypes { get; set; }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder){ //manda a la db los seeders
            base.OnModelCreating(modelBuilder);
            RoomTypeSeeder.Seed(modelBuilder);
            RoomSeeder.Seed(modelBuilder);
        }
        
    }
}