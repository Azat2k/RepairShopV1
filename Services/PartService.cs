using Microsoft.EntityFrameworkCore;
using RepairShopV1.Data;
using RepairShopV1.Models;

namespace RepairShopV1.Services
{
    public class PartService : IPartService
    {
        private readonly DataContext _context;

        public PartService(DataContext context)
        {
            _context = context;
        }
        
        public async Task<List<Part>> GetAllAsync()
        {
            return await _context.Parts.ToListAsync();
        }
        public async Task<Part> GetByIdAsync(int Id)
        {
            return await _context.Parts.FindAsync(Id);
        }
        public async Task<Part> AddAsync(Part part)
        {
            _context.Parts.Add(part);
            await _context.SaveChangesAsync();
            return part;
        }
        public async Task<Part> UpdateAsync(Part part)
        {
            _context.Entry(part).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return part;
        }
        public async Task DeleteAsync(int Id)
        {
            var part = await _context.Parts.FindAsync(Id);
            if (part != null)
            {
                _context.Parts.Remove(part);
                await _context.SaveChangesAsync();
            }
        }  
    }
}
