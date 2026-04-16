using DockerWebAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace DockerWebAPI.Services
{
    public class BrandService : IBrandService
    {
        private readonly BykeStoresContext bykeStores;

        public BrandService(BykeStoresContext bykeStores)
        {
            this.bykeStores = bykeStores;
        }
        public async Task<List<Brand>> GetAllBrands()
        {
            return await bykeStores.Brands.ToListAsync();
        }
    }
}
