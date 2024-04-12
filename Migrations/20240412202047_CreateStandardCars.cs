using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BilLagerAPI.Migrations
{
    public partial class CreateStandardCars : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int[]>(
                name: "Parts",
                table: "CustomCars",
                type: "integer[]",
                nullable: false,
                defaultValue: new int[0]);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Parts",
                table: "CustomCars");
        }
    }
}
