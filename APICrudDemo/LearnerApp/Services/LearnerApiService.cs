using LearnerApp.Models;

namespace LearnerApp.Services
{
    public class LearnerApiService
    {
        private readonly HttpClient http;
        public LearnerApiService(HttpClient http)
        {
            this.http = http;
        }

        public async Task<List<LearnerDto>> GetAllLearnersAsync()
        {
            return await http.GetFromJsonAsync<List<LearnerDto>>("api/learner");
        }

        public async Task<LearnerDto> AddLearnerAsync(LearnerDto learner)
        {
            var response = await http.PostAsJsonAsync("api/learner", learner);
            return await response.Content.ReadFromJsonAsync<LearnerDto>();
        }

        public async Task<LearnerDto> UpdateAsyncLearner(int id, LearnerDto learner)
        {
            var response= await http.PutAsJsonAsync($"api/learner/{id}", learner);
            return await response.Content.ReadFromJsonAsync<LearnerDto>();
        }


        public async Task DeleteLearnerasync(int id)
        {
            await http.DeleteAsync($"api/learner/{id}");
        }
    }
}
