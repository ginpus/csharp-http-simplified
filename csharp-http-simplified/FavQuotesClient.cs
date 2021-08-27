using csharp_http_simplified.Models.FavQuotes.ReadModels;
using csharp_http_simplified.Models.FavQuotes.WriteModels;
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

        public async Task<GetSingleQuote> ShowQuoteById(int id)
        {
            var url = $"/api/quotes/{id}";
            var result = await _httpClient.GetFromJsonAsync<GetSingleQuote>(url);
            return result;
        }

        public async Task PostQuote(string quote)
        {
            const string url = "/api/quotes";
            var post = new PostQuote
            {
                Quote = new PostQuoteContent
                {
                    Author = "Gintautas Pusinskas",
                    Body = "You are as no more nor less than you are."
                }
            };
            var response = await _httpClient.PostAsJsonAsync(url, post);
        }
    }
}