using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http.Headers;

namespace csharp_http_simplified
{
    public class Startup
    {
        public IServiceProvider ConfigureServices()
        {
            var services = new ServiceCollection();

            /*            services.AddHttpClient<IGithubClient, GithubClient>(httpClient =>
                        {
                            httpClient.BaseAddress = new Uri("https://api.github.com");
                        });

                        services.AddHttpClient<IJsonPlaceholderClient, JsonPlaceholderClient>(httpClient =>
                        {
                            httpClient.BaseAddress = new Uri("https://jsonplaceholder.typicode.com");
                        });*/

            services.AddHttpClient<IFavQuotesClient, FavQuotesClient>(httpClient =>
            {
                httpClient.BaseAddress = new Uri("https://favqs.com");
                httpClient.DefaultRequestHeaders.Add("Authorization", "Token token=6ec3ac06e0c549325cffffbb6ff79c85");
            });

            return services.BuildServiceProvider();
        }
    }
}