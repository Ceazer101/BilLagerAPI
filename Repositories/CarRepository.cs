
using CarStorageApi.Models;
using Microsoft.EntityFrameworkCore;
using CarStorageApi.Data;

namespace CarStorageApi.Repositories
{
    public class CarRepository: ICarRepository
    {
        private readonly CarContext _context;

        public CarRepository(CarContext context)
        {
            _context = context;
        }

        public List<Car> GetCars()
        {
            return _context.Cars.Include(x => x.Part).ToList();
        }

    }
}