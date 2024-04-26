using Microsoft.EntityFrameworkCore;
using RepairShopV1.Entities;

namespace RepairShopV1.Controllers
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) 
        {


        }
        DbSet<Part> Parts { get; set; }
    }
}
