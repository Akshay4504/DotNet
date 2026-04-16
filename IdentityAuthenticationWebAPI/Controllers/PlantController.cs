using IdentityAutheticationWebAPI.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace IdentityAuthenticationWebAPI.Controllers
{
    public class PlantController : ControllerBase
    {
        private readonly ApplicationDbContext _context;
        private readonly ILogger<PlantController> _logger;
        public PlantController(ApplicationDbContext context,ILogger<PlantController> logger)
        {
            _context = context;
            _logger = logger;
        }
        [AllowAnonymous]
        [HttpGet]

        public async Task<ActionResult> GetAllPlants()
        {
            List<Plant> plants = null;
            plants = await _context.Plants.ToListAsync();
            _logger.LogDebug("This is a debug log");
            _logger.LogInformation($"Tis is an informational log,User Accessed GetAllPlants.");
            return Ok(plants);
        }
        [Authorize(Roles ="Finance,Admin")]
        [HttpGet("{Id}")]

        public async Task<ActionResult> GetPlantById(int Id)
        {
            Plant plant;
            try
            {
                plant = await _context.Plants.SingleOrDefaultAsync(p => p.PlantId == Id);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
            return Ok(plant);
        }
    }
}
