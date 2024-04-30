using CarStorageApi.Models;

namespace CarStorageApi.Services
{
    public interface ICarService
    {
        public List<Car> GetCars();
    }
}
