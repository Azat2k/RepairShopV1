﻿namespace RepairShopV1.Models
{
    public class Service
    {
        public int Id { get; set; }
        public required string Name { get; set; }
        public string Description { get; set; } = string.Empty;
        public DateTime LaborHours { get; set; }
        public decimal LaborPrice { get; set; }
        public int PartId { get; set; }
        public List<Part>? Parts { get; set; }
        //public int EmployerId { get; set; }
    }
}
