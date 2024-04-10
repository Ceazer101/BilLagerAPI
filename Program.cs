using System;
using Microsoft.Extensions.Configuration;
using BilLagerAPI.Services; 
using BilLagerAPI.Data; 
using BilLagerAPI.Models;

namespace BilLagerAPI
{
    class Program
    {
        static void Main(string[] args)
        {
            var builder = new ConfigurationBuilder()
            .SetBasePath(AppDomain.CurrentDomain.BaseDirectory)
            .AddJsonFile("config/appsettings.json");

            IConfiguration configuration = builder.Build();

            DatabaseConnector databaseConnector = new DatabaseConnector(configuration);
            databaseConnector.Connect();

            CarContext context = new CarContext();
            CarOrder carOrder = new CarOrder(context);
            //carOrder.CreateCars();

            CarInventory carInventory = new CarInventory(context);
            List<Car> cars = carInventory.GetCars();

            foreach (Car car in cars)
            {
                Console.WriteLine($"Model: {car.Name}, Color: {car.Color}");Console.WriteLine($"Id: {car.Id}, Name: {car.Name}, Type: {car.Type}, Color: {car.Color}, Battery: {car.Battery}, Hitch: {car.Hitch}");
            }
            
        }
    }
}
