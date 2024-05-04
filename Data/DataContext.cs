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
        public DbSet<PartService> PartServices { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<PartService>()
                .HasKey(pt => new { pt.PartId, pt.ServiceId });

            modelBuilder.Entity<PartService>()
                .HasOne(pt => pt.Part)
                .WithMany(p => p.PartServices)
                .HasForeignKey(pt => pt.PartId);

            modelBuilder.Entity<PartService>()
                .HasOne(pt => pt.Service)
                .WithMany(t => t.PartServices)
                .HasForeignKey(pt => pt.ServiceId);
        }
    }
}
