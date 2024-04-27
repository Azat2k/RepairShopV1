using Microsoft.EntityFrameworkCore;
using RepairShopV1.Entities;

namespace RepairShopV1.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {


        }
        public DbSet<Part> Parts { get; set; }
    }
}
