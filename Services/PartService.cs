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

        public async Task<List<Part>> GetAllAsync()
        {
            try
            {
                return await _context.Parts.ToListAsync();
            }
            catch (Exception ex)
            {
                // Логирование ошибки или другие действия по обработке исключения
                throw new ApplicationException("An error occurred while retrieving parts.", ex);
            }
        }

        public async Task<Part> GetByIdAsync(int Id)
        {
            try
            {
                return await _context.Parts.FindAsync(Id);
            }
            catch (Exception ex)
            {
                // Логирование ошибки или другие действия по обработке исключения
                throw new ApplicationException($"An error occurred while retrieving part with ID {Id}.", ex);
            }
        }

        public async Task<Part> AddAsync(Part part)
        {
            if (part == null)
            {
                throw new ArgumentNullException(nameof(part));
            }

            if (!ValidatePart(part))
            {
                throw new ValidationException("The part model is not valid.");
            }

            try
            {
                _context.Parts.Add(part);
                await _context.SaveChangesAsync();
                return part;
            }
            catch (Exception ex)
            {
                // Логирование ошибки или другие действия по обработке исключения
                throw new ApplicationException("An error occurred while adding a new part.", ex);
            }
        }

        public async Task<Part> UpdateAsync(Part part)
        {
            if (part == null)
            {
                throw new ArgumentNullException(nameof(part));
            }

            if (!ValidatePart(part))
            {
                throw new ValidationException("The part model is not valid.");
            }

            try
            {
                _context.Entry(part).State = EntityState.Modified;
                await _context.SaveChangesAsync();
                return part;
            }
            catch (Exception ex)
            {
                // Логирование ошибки или другие действия по обработке исключения
                throw new ApplicationException($"An error occurred while updating part with ID {part.Id}.", ex);
            }
        }

        public async Task DeleteAsync(int Id)
        {
            try
            {
                var part = await _context.Parts.FindAsync(Id);
                if (part != null)
                {
                    _context.Parts.Remove(part);
                    await _context.SaveChangesAsync();
                }
            }
            catch (Exception ex)
            {
                // Логирование ошибки или другие действия по обработке исключения
                throw new ApplicationException($"An error occurred while deleting part with ID {Id}.", ex);
            }
        }

        // Метод для валидации модели Part
        private bool ValidatePart(Part part)
        {
            var validationContext = new ValidationContext(part);
            var validationResults = new List<ValidationResult>();
            return Validator.TryValidateObject(part, validationContext, validationResults, true);
        }
    }
}
