using IdentityAuthenticationWebAPI.Services;
using IdentityAuthenticationWebAPI.Services;
using IdentityAutheticationWebAPI.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Linq.Expressions;




namespace IdentityAuthenticationWebAPI.Controllers

{

    [Route("api")]

    [ApiController]

    public class AuthenticationController : ControllerBase

    {

        private readonly IAuthService _authService;

        private readonly ILogger<AuthenticationController> _logger;

        private readonly ApplicationDbContext _context;




        public AuthenticationController(

            IAuthService authService,

            ILogger<AuthenticationController> logger,

            ApplicationDbContext context)

        {

            _authService = authService;

            _logger = logger;

            _context = context;

        }

        [HttpPost]
        [Route("register")]

        public async Task<IActionResult> Register(User model)

        {

            if (!ModelState.IsValid)   // validation error

                return BadRequest(new { Status = "Error", Message = "Invalid Payload" });




            if (model.UserRole == "Admin" || model.UserRole == "Customer")

            {

                var (status, message) = await _authService.Registration(model, model.UserRole); // Call the Registration
                if (status == 0)

                {
                    return BadRequest(new { Status = "Error", Message = message });
                }
                var user = new User
                {
                    UserName = model.UserName,
                    Password = model.Password,
                    Email = model.Email,
                    MobileNumber = model.MobileNumber,
                    UserRole = model.UserRole

                };
                _context.Users.Add(model);
                await _context.SaveChangesAsync();


                return Ok(new { Status = "Success", Message = message, Data = user });
            }
            return BadRequest(new { Status = "Error", Message = "Invalid Role" });
        }
        [HttpPost]
        [Route("login")]
        public async Task<IActionResult> Login(LoginModel model)
        {
            try
            {
                if (!ModelState.IsValid)
                    return BadRequest(new { Status = "Error", Message = "Invalid Payload" });
                var (status, message) = await _authService.Login(model);
                if (status == 0) 
                    return BadRequest(new { Status = "Success", token = message });
                return Ok(new { status = "Success", token = message });
            }
            catch(Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }
    }
}