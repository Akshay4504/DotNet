using DockerWebAPI.Models;

namespace DockerWebAPI.Services
{
    public interface IBrandService
    {
        public Task<List<Brand>> GetAllBrands();
    }
}
