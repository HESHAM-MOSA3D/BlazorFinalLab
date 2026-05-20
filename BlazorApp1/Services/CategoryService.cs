using BlazorApp1.Models;
using System.Net.Http.Json;

namespace BlazorApp1.Services
{
    public class CategoryService
    {
        private readonly HttpClient _http;
        private const string BaseUrl = "https://6a0e0ca41736097c36097550.mockapi.io/Categories";

        public CategoryService(HttpClient http)
        {
            _http = http;
        }

        public async Task<List<Category>> GetAllAsync()
        {
            return await _http.GetFromJsonAsync<List<Category>>(BaseUrl)
                   ?? new List<Category>();
        }

        public async Task<Category?> GetByIdAsync(string id)
        {
            return await _http.GetFromJsonAsync<Category>($"{BaseUrl}/{id}");
        }

        public async Task CreateAsync(Category category)
        {
            await _http.PostAsJsonAsync(BaseUrl, category);
        }

        public async Task UpdateAsync(string id, Category category)
        {
            await _http.PutAsJsonAsync($"{BaseUrl}/{id}", category);
        }

        public async Task DeleteAsync(string id)
        {
            await _http.DeleteAsync($"{BaseUrl}/{id}");
        }
    }
}