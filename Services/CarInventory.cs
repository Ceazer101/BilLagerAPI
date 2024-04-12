using System.Collections.Generic;
using Microsoft.Extensions.Configuration;
using BilLagerAPI.Models;
using BilLagerAPI.Data;

public class CarInventory
{
    private readonly CarContext _context;

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
}