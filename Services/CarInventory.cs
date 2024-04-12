using System.Collections.Generic;
using Microsoft.Extensions.Configuration;
using BilLagerAPI.Models;
using BilLagerAPI.Data;

public class CarInventory
{
    private readonly CarContext _context;

    private List<StandardCar> _standardCars = new List<StandardCar>();

    public CarInventory(CarContext context)
    {
        _context = context;
    }

    public List<StandardCar> GetStandardCars()
    {
        return _context.StandardCars.ToList();
    }

    public List<CustomCar> GetCustomCars()
    {
        return _context.CustomCars.ToList();
    }

    public void CreateStandardCars()
    {
        StandardCar car1 = new StandardCar
        {
            Id = 3,
            Name = "SUV-X, White",
            Quantity = 9,
            Type = CarType.SUV,
            Color = "White",
            Battery = "50kW",
            Hitch = true
        };

        StandardCar car2 = new StandardCar
        {
            Id = 4,
            Name = "Sport-Y",
            Quantity = 5,
            Type = CarType.Sport,
            Color = "Red",
            Battery = "100kW",
            Hitch = false
        };

        _standardCars.Add(car1);
        _standardCars.Add(car2);
    }
}