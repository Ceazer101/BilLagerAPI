using System;
using Microsoft.Extensions.Configuration;
using BilLagerAPI.Services;
using BilLagerAPI.Data;
using BilLagerAPI.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

public class Program
{
    public static void Main(string[] args)
    {
        CreateHostBuilder(args).Build().Run();
    }

    public static IHostBuilder CreateHostBuilder(string[] args) =>
        Host.CreateDefaultBuilder(args)
        .ConfigureWebHostDefaults(webBuilder =>
    {
        webBuilder.ConfigureServices(services =>
        {
            // Add services here
        })
        .Configure((context, app) =>
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(context.HostingEnvironment.ContentRootPath)
                .AddJsonFile("config/appsettings.json");

            IConfiguration configuration = builder.Build();

            DatabaseConnector databaseConnector = new DatabaseConnector(configuration);
            databaseConnector.Connect();

            CarContext carContext = new CarContext();

            CarInventory carInventory = new CarInventory(carContext);

            var missingMigrations = carContext.Database.GetPendingMigrations();
            if (missingMigrations.Any())
            {
                carContext.Database.Migrate();
            }

            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapGet("/", async context =>
                {
                    List<StandardCar> standardCars = carInventory.GetStandardCars();
                    foreach (StandardCar car in standardCars)
                    {
                        await context.Response.WriteAsync($"Model: {car.Name}, Color: {car.Color}\n");
                        await context.Response.WriteAsync($"Id: {car.Id}, Name: {car.Name}, Type: {car.Type}, Color: {car.Color}, Battery: {car.Battery}, Hitch: {car.Hitch}\n");
                    }
                });
            });
        });
    });
}