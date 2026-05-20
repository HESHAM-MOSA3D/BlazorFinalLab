using BlazorApp1.Models;
using BlazorApp1.Models;
using System.Net.Http.Json;

namespace BlazorApp1.Services
{
    public class CourseService
    {
        private readonly HttpClient _http;
        private const string BaseUrl = "https://6a0e0ca41736097c36097550.mockapi.io/Courses";

        public CourseService(HttpClient http)
        {
            _http = http;
        }

        public async Task<List<Course>> GetAllAsync()
        {
            return await _http.GetFromJsonAsync<List<Course>>(BaseUrl)
                   ?? new List<Course>();
        }

        public async Task<Course?> GetByIdAsync(string id)
        {
            return await _http.GetFromJsonAsync<Course>($"{BaseUrl}/{id}");
        }

        public async Task CreateAsync(Course course)
        {
            await _http.PostAsJsonAsync(BaseUrl, course);
        }

        public async Task UpdateAsync(string id, Course course)
        {
            await _http.PutAsJsonAsync($"{BaseUrl}/{id}", course);
        }

        public async Task DeleteAsync(string id)
        {
            await _http.DeleteAsync($"{BaseUrl}/{id}");
        }
    }
}