namespace RepairShopV1.Entities
{
    public class Part
    {
        public int Id { get; set; }
        public int PartNumber { get; set; }
        public required string Name { get; set; }
        public string Description { get; set; } = string.Empty;
        public decimal Price { get; set; }
        public decimal SellPrice { get; set; }
        public int ServiceID { get; set; }
        public List<Service>? Services { get; set; }
    }
}
