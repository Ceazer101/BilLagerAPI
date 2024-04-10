using System;
using System.Collections.Generic;

namespace BilLagerAPI.Models
{
    public class Car
    {
        public int Id { get; set; }
        public DateTime? ManufactureDate  { get; set; }
        public DateTime? OrderDate { get; set; }
        public string Name { get; set; } = "";
        public CarType Type { get; set; }
        public string Color { get; set; } = "";
        public string Battery { get; set; } = "";
        public bool Hitch;
        //public List<Part> Parts { get; set; } = new List<Part>(); 
    }

     public enum CarType
    {
        SUV,
        Sport
    }

    /*public class Part
    {
        public int Id { get; set; }
        public PartType Type { get; set; }
        public DateTime OrderDate { get; set; }
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
    }*/
}
