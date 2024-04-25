using System;
using System.Collections.Generic;

namespace CarStorageAPI.Models
{
    public class Car
    {
        public int Id { get; set; }
        public string Name { get; set; } = "";
        public CarType Type { get; set; }
        public string Color { get; set; } = "";
        public string Battery { get; set; } = "";
        public bool Hitch;
        public List<PartType> Parts { get; set; } = new List<PartType>();
    }

    public enum CarType
    {
        SUV = 1,
        Sport = 2
    }

    public class Part
    {
        public int Id { get; set; }
        public PartType Type { get; set; }
        public int? CarId { get; set; }
        public List<PartType> Attributes { get; set; } = new List<PartType>();
    }

    public enum PartType
    {
        Wheel,
        ElMotor,
        Door,
        Frame,
        Seat,
        Window,
        Axel,
        Computer,
        Roof,
    }

}
