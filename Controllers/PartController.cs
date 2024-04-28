using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RepairShopV1.Data;
using RepairShopV1.Entities;
using RepairShopV1.Services;

namespace RepairShopV1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PartController : ControllerBase
    {
        private readonly IPartService _partService;
        public PartController(IPartService partService)
        {
            _partService = partService;
        }

        [HttpGet]
        public async Task<ActionResult<Part>> GetAllParts()
        {
            var parts = await _partService.GetAllAsync();

            return Ok(parts);
            //https://localhost:7215/Api/Part
        }

        [HttpGet]
        [Route("{Id}")]
        public async Task<ActionResult<List<Part>>> GetPartById(int Id)
        {
            var parts = await _partService.GetByIdAsync(Id);
            if (parts is null) 
            {
                return NotFound("Part not found.");
            }

            return Ok(parts);
            //https://localhost:7215/Api/Part/1
        }
    }
}
