
using CarStorageAPI.Models;
using CarStorageAPI.Data;

namespace CarStorageApi.Repositories
{
    public class CarRepository: ICarRepository
    {
        private readonly CarContext _context;

        public CarRepository(CarContext context)
        {
            _context = context;
        }

        public List<StandardCar> GetStandardCars()
        {
            return _context.StandardCars.ToList();
        }

        public List<CustomCar> GetCustomCars()
        {
            return _context.CustomCars.ToList();
        }

    }
}