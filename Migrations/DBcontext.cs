using Microsoft.EntityFrameworkCore;
using BilLagerAPI.Models;

namespace BilLagerAPI.Data
{
    public class CarContext : DbContext
    {
        public DbSet<StandardCar> StandardCars { get; set; }
        public DbSet<CustomCar> CustomCars { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Host=host.docker.internal;Port=5432;Database=BilLagerDB;Username=guest;Password=guest;");
        }
    }
}