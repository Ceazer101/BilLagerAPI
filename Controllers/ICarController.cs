using CarStorageApi.Models;

namespace CarStorageApi.Controllers
{
    public interface ICarController
    {
        public List<Car> GetCars();
    }
}