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
            optionsBuilder.UseNpgsql("Server=localhost;Port=5432;Database=BilLagerDB;User Id=postgres;Password=testtest;");
        }
    }
}