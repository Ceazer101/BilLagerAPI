
namespace CarStorageAPI.Models
{
    public class CustomCar
    {
        public int Id { get; set; }
        public string Name { get; set; } = "";
        public int Quantity { get; set; }
        public CarType Type { get; set; }
        public string Color { get; set; } = "";
        public string Battery { get; set; } = "";
        public bool Hitch;
        public List<PartType> Parts { get; set; } = new List<PartType>(); 
    }

    /*public class Part
    {
        public int Id { get; set; }
        public PartType Type { get; set; }
        public DateTime OrderDate { get; set; }
        public int? CarId { get; set; }
        public List<PartType> Attributes { get; set; } = new List<PartType>();
    }*/

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