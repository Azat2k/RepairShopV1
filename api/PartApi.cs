using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RepairShopV1.Data;
using RepairShopV1.Models;
using RepairShopV1.Services;

namespace RepairShopV1.api
{
    [Route("api/[controller]")]
    [ApiController]
    public class PartApi : ControllerBase
    {
        private readonly IPartService _partService;
        public PartApi(IPartService partService)
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
