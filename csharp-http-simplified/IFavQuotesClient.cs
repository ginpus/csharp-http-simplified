using csharp_http_simplified.Models.FavQuotes.ReadModels;
using csharp_http_simplified.Models.FavQuotes.WriteModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace csharp_http_simplified
{
    internal interface IFavQuotesClient
    {
        Task<GetQuotes> ShowAllQuotes();

        Task<GetSingleQuote> ShowQuoteById(int id);

        Task<PostUserResponse> CreateUserSession(string login, string password);

        Task<HttpResponseMessage> PostQuote(string author, string quote, string userToken);
    }
}