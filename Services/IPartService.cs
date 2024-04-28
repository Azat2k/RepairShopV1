using RepairShopV1.Models;

namespace RepairShopV1.Services
{
    public interface IPartService
    {
        Task<List<Part>> GetAllAsync();
        Task<Part> GetByIdAsync(int Id);
        Task<Part> AddAsync(Part part);
        Task<Part> UpdateAsync(Part part);
        Task DeleteAsync(int Id);
    }
}
