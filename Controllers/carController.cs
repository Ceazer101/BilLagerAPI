using Microsoft.AspNetCore.Mvc;
using CarStorageApi.Services;

namespace CarStorageAPI.Controllers
{

    public class CarController: ICarController
    {
        private ICarService _carService;
        public CarController(ICarService carService) 
        {
            _carService = carService;
        }

        public void GetStandardCars()
        {
            _carService.GetStandardCars();
        }
    }
}
