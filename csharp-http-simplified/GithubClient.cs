using csharp_http_simplified.Models.Github.ResponseModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;

namespace csharp_http_simplified
{
    public class GithubClient : IGithubClient
    {
        private readonly HttpClient _httpClient;

        public GithubClient(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<UserResponseModel> GetUser(string username)
        {
            var url = $"/users/{username}";

            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri(_httpClient.BaseAddress, url)
            };

            request.Headers.Add("User-Agent", "Lecture 37");

            var response = await _httpClient.SendAsync(request);

            return await response.Content.ReadFromJsonAsync<UserResponseModel>();
        }
    }
}