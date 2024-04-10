using Npgsql;
using Microsoft.Extensions.Configuration;
using System;

public class DatabaseConnector
{
    private readonly IConfiguration _configuration;
    
    public DatabaseConnector(IConfiguration configuration)
    {
        _configuration = configuration;
    }

    public void Connect()
    {
        string connectionString = _configuration.GetConnectionString("DefaultConnection");

        using (var connection = new NpgsqlConnection(connectionString))
        {
            try
            {
                connection.Open();
                Console.WriteLine("Connected to PostgreSQL database!");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }
    }
}
