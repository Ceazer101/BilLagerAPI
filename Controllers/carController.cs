using Microsoft.AspNetCore.Mvc;
using CarStorageApi.Services;

namespace CarStorageApi.Controllers
{

    public class CarController: ICarController
    {
        private ICarService _carService;
        public CarController(ICarService carService) 
        {
            _carService = carService;
        }

        public void GetCars()
        {
            _carService.GetCars();
        }
    }
}
