using csharp_http_simplified.Models.FavQuotes.ReadModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_http_simplified
{
    internal interface IFavQuotesClient
    {
        Task<GetQuotes> ShowAllQuotes();
    }
}