using RepairShopV1.Models;

namespace RepairShopV1.Services
{
    public interface IPartService
    {
        Task<List<Part>> GetAllParts();
        Task<Part> GetPartById(int id);
        Task CreatePart(Part part);
        Task UpdatePart(Part part);
        Task DeletePart(int id);
    }
}
