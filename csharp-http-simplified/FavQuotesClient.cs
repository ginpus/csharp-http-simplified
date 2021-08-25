using csharp_http_simplified.Models.FavQuotes.ReadModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;

namespace csharp_http_simplified
{
    internal class FavQuotesClient : IFavQuotesClient
    {
        private readonly HttpClient _httpClient;

        public FavQuotesClient(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public Task<GetQuotes> ShowAllQuotes()
        {
            const string url = "/api/quotes";
            return _httpClient.GetFromJsonAsync<GetQuotes>(url);
        }
    }
}