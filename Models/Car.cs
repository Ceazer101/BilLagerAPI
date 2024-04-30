using System;
using System.Collections.Generic;

namespace CarStorageApi.Models
{
    public class Car
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = "";
        public string Type { get; set; }
        public string Color { get; set; } = "";
        public List<Part> Part { get; set; } = new List<Part>();
    }
}
