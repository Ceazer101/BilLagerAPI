using BilLagerAPI.Models;

internal class Program
{
    private static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);
        builder.Services.AddEndpointsApiExplorer();
        builder.Services.AddSwaggerGen();

        var app = builder.Build();

        app.UseRouting();
        app.MapGet("/", () => "Hello World!");
        app.UseSwagger();
        app.UseSwaggerUI();

        app.Run();
    }
}