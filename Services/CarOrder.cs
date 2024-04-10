using System;
using Microsoft.Extensions.Configuration;
using BilLagerAPI.Models;
using BilLagerAPI.Data;

namespace BilLagerAPI.Services {
    public class CarOrder {
        private readonly CarContext _context;

        public CarOrder(CarContext context) {
            _context = context;
        }

        public void CreateCars() {
            Car car1 = new Car{
                Id = 3,
                Name = "SUV, White X",
                Type = CarType.SUV,
                Color = "White",
                Battery = "50kW",
                Hitch = true
            };

            Car car2 = new Car{
                Id = 4,
                Name = "Sport-Y",
                Type = CarType.Sport,
                Color = "Red",
                Battery = "100kW",
                Hitch = false
            };

            _context.Cars.Add(car1);
            _context.Cars.Add(car2);

            _context.SaveChanges();
        }
    }
    
}