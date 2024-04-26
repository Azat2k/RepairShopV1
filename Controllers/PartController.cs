using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RepairShopV1.Entities;

namespace RepairShopV1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PartController : ControllerBase //fat controller
    {
        [HttpGet]
        public async Task<ActionResult<List<Part>>> GetAllParts()
        {
            var parts = new List<Part>
            {
                new Part
                {
                    Id = 1,
                    PartNumber = 1,
                    Name = "Test",
                    Description = "Test",
                    Price = 1,
                    SellPrice = 1,
                    ServiceID = 1
                }
            };
            return Ok(parts);
            //https://localhost:7215/Api/Part
        }
    }
}
