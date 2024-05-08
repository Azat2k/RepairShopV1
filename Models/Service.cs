namespace RepairShopV1.Models
{
    public class Service
    {
        public int Id { get; set; }
        public required string Name { get; set; }
        public string Description { get; set; } = string.Empty;
        public TimeSpan LaborHours { get; set; }
        public decimal LaborPrice { get; set; }
        public List<PartService>? PartServices { get; set; }
    }
}
