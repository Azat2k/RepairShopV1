using Microsoft.EntityFrameworkCore;
using RepairShopV1.Models;

namespace RepairShopV1.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {


        }
        public DbSet<Part> Parts { get; set; }
        public DbSet<Service> Services { get; set; }
    }
}
