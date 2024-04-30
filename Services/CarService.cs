using CarStorageApi.Repositories;
using CarStorageApi.Models;

namespace CarStorageApi.Services
{
    public class CarService: ICarService
    {
        private ICarRepository _carInventoryRepo;

        public CarService(ICarRepository carInventoryRepo)
        {
            _carInventoryRepo = carInventoryRepo;
        }

        public List<Car> GetCars()
        {
            return _carInventoryRepo.GetCars();
        }
    }
}
