using IdentityAuthenticationWebAPI.Models;
using IdentityAuthenticationWebAPI.Services;
//using IdentityAutheticationWebAPI.Migrations;
using IdentityAutheticationWebAPI.Models;
//using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace IdentityAutheticationWebAPI.Services
{
    public class AuthService : IAuthService
    {
        private readonly UserManager<ApplicationUser> userManager;
        private readonly ApplicationDbContext context;
        private readonly RoleManager<IdentityRole> roleManager;
        private readonly IConfiguration configuration;

        public AuthService(UserManager<ApplicationUser> userManager, RoleManager<IdentityRole> roleManager,
                    IConfiguration configuration, ApplicationDbContext context)
        {
            this.userManager = userManager;
            this.roleManager = roleManager;
            this.configuration = configuration;
            this.context = context;
        }

        public async Task<(int, string)> Registration(User model, string role)
        {
            var userExists = await userManager.FindByEmailAsync(model.Email);
            if (userExists != null)
            {
                return (0, "User Already exist");
            }

            ApplicationUser user = new ApplicationUser()
            {
                UserName = model.UserName,
                Email = model.Email,
                SecurityStamp = Guid.NewGuid().ToString(), //Globally Unique ID
                UserPreference = "Default"
            };

            var createUserResult = await userManager.CreateAsync(user, model.Password);
            if (!createUserResult.Succeeded)
            {
                return (0, "User creation failed! Please Check user details and try again");
            }
            if (!await roleManager.RoleExistsAsync(role))
                await roleManager.CreateAsync(new IdentityRole(role));
            if (!await roleManager.RoleExistsAsync(UserRoles.User))
                await roleManager.CreateAsync(new IdentityRole(UserRoles.User));
            if (!await roleManager.RoleExistsAsync(UserRoles.User))
                await userManager.AddToRoleAsync(user, UserRoles.User);
            await userManager.AddToRoleAsync(user, role);
            return (1, "User Created successfully");

        }
        public async Task<(int, string)> Login(LoginModel model)

        {

            var user = await userManager.FindByEmailAsync(model.Email);

            var users = await context.Users.FirstOrDefaultAsync(u => u.Email == model.Email);

            var userRoles = await userManager.GetRolesAsync(user);

            Console.WriteLine(string.Join(", ", user));

            Console.WriteLine(string.Join(", ", userRoles));

            if (user == null)

                return (0, "Invalid username");

            if (!await userManager.CheckPasswordAsync(user, model.Password)) return (0, "Invalid Password");

            var authClaims = new List<Claim>

            {

                new Claim(ClaimTypes.Name,user.UserName),

                new Claim(ClaimTypes.NameIdentifier,users.UsertId.ToString()),

                new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString())

            };

            foreach (var userRole in userRoles)

            {

                authClaims.Add(new Claim(ClaimTypes.Role, userRole));

            }

            string token = GenerateToken(authClaims);

            return (1, token);

        }

        private string GenerateToken(IEnumerable<Claim> claims)
        {

            Console.WriteLine(claims);

            var authSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(configuration["JWT:Secret"]));

            var tokenDescriptor = new SecurityTokenDescriptor

            {

                Issuer = configuration["JWT:ValidIssuer"],

                Audience = configuration["JWT:ValidAudience"],

                Expires = DateTime.UtcNow.AddHours(3),
                SigningCredentials = new SigningCredentials(authSigningKey, SecurityAlgorithms.HmacSha256),
                Subject = new ClaimsIdentity(claims),
            };
            Console.WriteLine(tokenDescriptor);
            var tokenHandler = new JwtSecurityTokenHandler();
            var token=tokenHandler.CreateToken(tokenDescriptor);
            Console.WriteLine($"TOken: {token}");
            return tokenHandler.WriteToken(token);

        }

    }
}