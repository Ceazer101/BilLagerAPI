using Microsoft.EntityFrameworkCore;
using CarStorageAPI.Models;

namespace CarStorageAPI.Data
{
    public class CarContext : DbContext
    {
        public DbSet<Car> Cars { get; set; }
        public CarContext(DbContextOptions options) : base(options) { }
    }
}