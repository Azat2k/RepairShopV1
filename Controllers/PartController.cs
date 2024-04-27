using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RepairShopV1.Data;
using RepairShopV1.Entities;

namespace RepairShopV1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PartController : ControllerBase //fat controller
    {
        private readonly DataContext _context;

        public PartController(DataContext contex)
        {
            _context = contex;
        }


        [HttpGet]
        public async Task<ActionResult<List<Part>>> GetAllParts()
        {
            var parts = await _context.Parts.ToListAsync();

            return Ok(parts);
            //https://localhost:7215/Api/Part
        }

        [HttpGet]
        [Route("{Id}")]
        public async Task<ActionResult<List<Part>>> GetPart(int id)
        {
            var parts = await _context.Parts.FindAsync(id);
            if (parts is null) 
            {
                return BadRequest("Part not found.");
            }

            return Ok(parts);
            //https://localhost:7215/Api/Part/1
        }
    }
}
