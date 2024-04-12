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
            StandardCar car1 = new StandardCar{
                Id = 3,
                Name = "SUV-X, White",
                Quantity = 9,
                Type = CarType.SUV,
                Color = "White",
                Battery = "50kW",
                Hitch = true
            };

            StandardCar car2 = new StandardCar{
                Id = 4,
                Name = "Sport-Y",
                Quantity = 5,
                Type = CarType.Sport,
                Color = "Red",
                Battery = "100kW",
                Hitch = false
            };

            _context.StandardCars.Add(car1);
            _context.StandardCars.Add(car2);

            _context.SaveChanges();
        }
    }
    
}