using IdentityAutheticationWebAPI.Models;

namespace IdentityAuthenticationWebAPI.Services
{
    public interface IAuthService
    {
        Task<(int, string)> Registration(User model, string role);
        Task<(int, string)> Login(LoginModel model);

    }
}
