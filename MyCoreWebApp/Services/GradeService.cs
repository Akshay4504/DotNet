using MyCoreWebApp.Models;
using Newtonsoft.Json;
using System.Net.Http;

namespace MyCoreWebApp.Services
{
    public class GradeService : IGradeService
    {
        private readonly IHttpClientFactory _httpClient;
        private readonly string baseUrl = "https://localhost:7133/api/Grade/";

        public GradeService(IHttpClientFactory httpClientFactory)
        {
            _httpClient = httpClientFactory;
            
        }

        public async Task<List<Grade>> GetAllGrades()
        {
            var client = _httpClient.CreateClient();
            client.BaseAddress = new Uri(baseUrl);
            List<Grade> grades = null;

            try
            {
                var response = await client.GetAsync("GetAllgrades");
                response.EnsureSuccessStatusCode();

                string json = await response.Content.ReadAsStringAsync();

                grades = JsonConvert.DeserializeObject<List<Grade>>(json);

            }
            catch (HttpRequestException ex)
            {
                throw ex;
            }
            return grades;
        }

        public async Task<int> AddGrade(Grade grd)
        {
            var client = _httpClient.CreateClient();
            client.BaseAddress = new Uri(baseUrl);

            try
            {
                HttpResponseMessage response = await client.PostAsJsonAsync($"AddGrade",grd);
                response.EnsureSuccessStatusCode();

                string json = await response.Content.ReadAsStringAsync();

                int result = JsonConvert.DeserializeObject<int>(json);
                return result;

            }
            catch (HttpRequestException ex)
            {
                throw ex;
            }
        }
        public async Task<Grade> GetGradeById(int grdId)
        {
            Grade grd = null;
            var client = _httpClient.CreateClient();
            client.BaseAddress = new Uri(baseUrl);

            try
            {
                var response = await client.GetAsync($"GetGradeById/{grdId}");
                response.EnsureSuccessStatusCode();

                string json = await response.Content.ReadAsStringAsync();

                int result = JsonConvert.DeserializeObject<int>(json);
                

            }
            catch (HttpRequestException ex)
            {
                throw ex;
            }
            return grd;
        }
        public async Task<int> UpdateGrade(int id, Grade grd)
        {

            var client = _httpClient.CreateClient();
            client.BaseAddress = new Uri(baseUrl);
            try
            {
                // Make PUT request
                HttpResponseMessage response = await client.PutAsJsonAsync($"UpdateGrade/{id}", grd);
                // Ensure success
                response.EnsureSuccessStatusCode();
                // Read response
                string json = await response.Content.ReadAsStringAsync();
                // Deserialize result
                int result = JsonConvert.DeserializeObject<int>(json);
                return result;
            }
            catch (HttpRequestException e)
            {
                throw e;
            }
        }

    }
}
