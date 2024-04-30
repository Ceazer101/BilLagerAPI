namespace CarStorageApi.Models
{
    public class Part
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public Car Car { get; set; }
        public Guid CarId { get; set; }
    }
}