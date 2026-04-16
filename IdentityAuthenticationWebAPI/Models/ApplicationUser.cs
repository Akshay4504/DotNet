using Microsoft.AspNetCore.Identity;

namespace IdentityAuthenticationWebAPI.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string UserPreference { get; set; } = default;
    }
}
