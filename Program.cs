using System;
using Microsoft.Extensions.Configuration;
using BilLagerAPI.Services; 
using BilLagerAPI.Data; 
using BilLagerAPI.Models;
using Microsoft.EntityFrameworkCore;

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

            CarInventory carInventory = new CarInventory(context);
            //carInventory.CreateStandardCars();
            var missingMigrations = context.Database.GetPendingMigrations();
            if (missingMigrations.Any())

            {

                context.Database.Migrate();

            }
            List<StandardCar> standardCars = carInventory.GetStandardCars();
            foreach (StandardCar car in standardCars)
            {
                Console.WriteLine($"Model: {car.Name}, Color: {car.Color}");Console.WriteLine($"Id: {car.Id}, Name: {car.Name}, Type: {car.Type}, Color: {car.Color}, Battery: {car.Battery}, Hitch: {car.Hitch}");
            }
            
            RabbitMQService rabbitMQService = new RabbitMQService("host.docker.internal", "test_queue", "guest", "guest");
            rabbitMQService.SendMessage("Hello, RabbitMQ!");
        }
    }
}
