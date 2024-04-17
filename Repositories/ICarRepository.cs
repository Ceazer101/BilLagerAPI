using CarStorageAPI.Models;

namespace CarStorageApi.Repositories
{
    public interface ICarRepository
    {
        public List<StandardCar> GetStandardCars();
    }
}
