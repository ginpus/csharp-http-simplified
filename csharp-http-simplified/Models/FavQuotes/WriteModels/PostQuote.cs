using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace csharp_http_simplified.Models.FavQuotes.WriteModels
{
    public class PostQuote
    {
        [JsonPropertyName("quote")]
        public PostQuoteContent Quote { get; set; }
    }
}