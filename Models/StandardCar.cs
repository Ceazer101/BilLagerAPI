using System;
using System.Collections.Generic;

namespace CarStorageAPI.Models
{
    public class StandardCar
    {
        public int Id { get; set; }
        public string Name { get; set; } = "";
        public int Quantity { get; set; }
        public CarType Type { get; set; }
        public string Color { get; set; } = "";
        public string Battery { get; set; } = "";
        public bool Hitch;
    }

    public enum CarType
    {
        SUV = 1,
        Sport = 2
    }

}
