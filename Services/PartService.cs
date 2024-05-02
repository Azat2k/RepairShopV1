using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RepairShopV1.Data;
using RepairShopV1.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;

namespace RepairShopV1.Services
{
    public class PartService : IPartService
    {
        private readonly DataContext _context;

        public PartService(DataContext context)
        {
            _context = context;
        }

        public async Task<List<Part>> GetAllParts()
        {
            return await _context.Parts.ToListAsync();
        }

        public async Task<Part> GetPartById(int id)
        {
            return await _context.Parts.FirstOrDefaultAsync(p => p.Id == id);
        }

        public async Task CreatePart(Part part)
        {
            _context.Parts.Add(part);
            await _context.SaveChangesAsync();
        }

        public async Task UpdatePart(Part part)
        {
            _context.Entry(part).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }

        public async Task DeletePart(int id)
        {
            var partToDelete = await _context.Parts.FindAsync(id);
            if (partToDelete != null)
            {
                _context.Parts.Remove(partToDelete);
                await _context.SaveChangesAsync();
            }
        }
    }
}
