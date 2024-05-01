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
        public DateTime? CreatedDate { get; set; }
        public DateTime? SoldDate { get; set; } 
        public virtual List<Part> Part { get; set; } = new List<Part>();
    }
}
