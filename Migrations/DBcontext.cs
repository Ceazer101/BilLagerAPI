using Microsoft.EntityFrameworkCore;
using CarStorageAPI.Models;

namespace CarStorageAPI.Data
{
    public class CarContext : DbContext
    {
        public DbSet<StandardCar> StandardCars { get; set; }
        public DbSet<CustomCar> CustomCars { get; set; }
        public CarContext(DbContextOptions options) : base(options) { }
    }
}