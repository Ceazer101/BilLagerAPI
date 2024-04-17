using BilLagerAPI.Controllers;
using BilLagerAPI.Data;
using BilLagerAPI.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;

internal class Program
{
    private static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        var configuration = builder.Configuration;

        builder.Services.AddEndpointsApiExplorer();
        builder.Services.AddDbContext<CarContext>(options =>
            options.UseNpgsql(configuration.GetConnectionString("DefaultConnection")));
        builder.Services.AddSwaggerGen();
        var app = builder.Build();
        using (var scope = app.Services.CreateScope())
        {
            var db = scope.ServiceProvider.GetRequiredService<CarContext>();
            db.Database.Migrate();
        }
        app.UseRouting();
        app.MapGet("/", () => "Hello World!");
        app.UseSwagger();
        app.UseSwaggerUI();

        app.Run();
    }
}