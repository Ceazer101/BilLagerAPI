using System.Collections.Generic;
using Microsoft.Extensions.Configuration;
using BilLagerAPI.Models;
using BilLagerAPI.Data;

namespace BilLagerAPI.Services
{
    public class CarInventory
    {
        private readonly CarContext _context;

        public CarInventory(CarContext context)
        {
            _context = context;
        }

        public List<Car> GetCars()
        {
            return _context.Cars.ToList();
        }
    }
}