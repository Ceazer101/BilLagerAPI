using Microsoft.AspNetCore.Mvc;
using CarStorageApi.Services;
using CarStorageApi.Models;

namespace CarStorageApi.Controllers
{

    public class CarController: ICarController
    {
        private ICarService _carService;
        public CarController(ICarService carService) 
        {
            _carService = carService;
        }

        public List<Car> GetCars()
        {
            return _carService.GetCars();
        }
    }
}
