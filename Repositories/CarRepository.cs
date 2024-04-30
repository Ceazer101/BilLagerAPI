
using CarStorageApi.Models;
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
            return _context.Cars.ToList();
        }

    }
}