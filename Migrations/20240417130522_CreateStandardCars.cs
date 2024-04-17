using Microsoft.EntityFrameworkCore.Migrations;
using CarStorageAPI.Models;
using System.Collections.Generic;
using System.Drawing;
using System.Xml.Linq;

#nullable disable

namespace CarStorageAPI.Migrations
{
    /// <inheritdoc />
    public partial class CreateStandardCars : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "StandardCars",
                columns: new[] { "Id", "Name", "Quantity", "Type", "Color", "Battery", "Hitch" },
                values: new object[] { 3, "SUV-X, White", 9, CarType.SUV, "White", "50kW", true });

            migrationBuilder.InsertData(
                table: "StandardCars",
                columns: new[] { "Id", "Name", "Quantity", "Type", "Color", "Battery", "Hitch" },
                values: new object[] { 4, "Sport-Y", 5, CarType.Sport, "Red", "100kW", false });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"DELETE FROM StandardCars(Name, Quantity, Type, Color, Battery, Hitch)
            VALUES
            ('SUV-X, White', 9, 'SUV', 'White', '50kW', true),
            ('Sport-Y', 5, 'Sport', 'Red', '100kW', false);"
            );
        }
    }
}
