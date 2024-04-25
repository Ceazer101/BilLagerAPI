using CarStorageApi.Repositories;
using CarStorageAPI.Models;

namespace CarStorageApi.Services
{
    public class CarService: ICarService
    {
        private ICarRepository _carInventoryRepo;

        public CarService(ICarRepository carInventoryRepo)
        {
            _carInventoryRepo = carInventoryRepo;
        }

        public void GetCars()
        {
            _carInventoryRepo.GetCars();
        }
        
    }
}
