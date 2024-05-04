namespace RepairShopV1.Models
{
    public class PartService
    {
        public int PartId { get; set; }
        public Part? Part { get; set; }
        public int ServiceId { get; set; }
        public Service? Service { get; set; }
    }
}
