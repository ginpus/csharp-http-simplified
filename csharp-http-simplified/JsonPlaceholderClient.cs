using csharp_http_simplified.Models.JsonPlaceholder.ReadModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;

namespace csharp_http_simplified
{
    public class JsonPlaceholderClient : IJsonPlaceholderClient
    {
        private readonly HttpClient _httpClient;

        public JsonPlaceholderClient(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public Task<IEnumerable<PostResponseModel>> GetPosts()
        {
            const string url = "/posts";
            return _httpClient.GetFromJsonAsync<IEnumerable<PostResponseModel>>(url);
        }

        public async Task<PostResponseModel> GetPost(int id)
        {
            var url = $"/posts?id={id}";
            var result = await _httpClient.GetFromJsonAsync<IEnumerable<PostResponseModel>>(url);
            return result.First();
        }

        public async Task<IEnumerable<GetUsers>> GetUsers()
        {
            var url = "/users";
            var result = await _httpClient.GetFromJsonAsync<IEnumerable<GetUsers>>(url);
            return result;
        }

        public async Task<GetUsers> GetUser(int id)
        {
            var url = $"/users/{id}";
            var result = await _httpClient.GetFromJsonAsync<GetUsers>(url);
            return result;
        }

        public async Task<IEnumerable<GetTodos>> GetTodoItems(int userId)
        {
            var url = $"/todos?userId={userId}";
            var result = await _httpClient.GetFromJsonAsync<IEnumerable<GetTodos>>(url);
            return result;
        }

        public async Task<IEnumerable<GetTodos>> GetTodosByStatus(int userId, bool isCompleted)
        {
            var url = $"/todos?userId={userId}&completed={isCompleted.ToString().ToLower()}";
            var result = await _httpClient.GetFromJsonAsync<IEnumerable<GetTodos>>(url);
            return result;
        }
    }
}