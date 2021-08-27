using System;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;

namespace csharp_http_simplified
{
    internal class Program
    {
        public static async Task Main(string[] args)
        {
            var startup = new Startup();
            var serviceProvider = startup.ConfigureServices();

            var favQuotesClient = serviceProvider.GetService<IFavQuotesClient>();

            Console.WriteLine("----------Get all quotes----------");
            var quotes = await favQuotesClient.ShowAllQuotes();

            //Console.WriteLine(quotes);

            foreach (var quote in quotes.Quotes)
            {
                Console.WriteLine(quote);
            }

            Console.WriteLine("----------Get single quote----------");
            Console.WriteLine("Select quote ID:");
            var selectedQuoteId = Convert.ToInt32(Console.ReadLine());

            var quoteById = await favQuotesClient.ShowQuoteById(selectedQuoteId);

            Console.WriteLine(quoteById);

            Console.WriteLine("----------Post a quote----------");

            var response = await favQuotesClient.PostQuote(post);
            Console.WriteLine(response.EnsureSuccessStatusCode());

            // -------------------Placeholder APP------------------------------

            /*            var jsonPlaceholderClient = serviceProvider.GetService<IJsonPlaceholderClient>();

                        Console.WriteLine("----------Get all users----------");
                        var users = await jsonPlaceholderClient.GetUsers();

                        foreach (var user in users)
                        {
                            Console.WriteLine(user);
                        }

                        Console.WriteLine("----------Get user by id----------");
                        Console.WriteLine("Select user ID to get user info:");
                        var selectedUserId = Convert.ToInt32(Console.ReadLine());

                        var selectedUser = await jsonPlaceholderClient.GetUser(selectedUserId);

                        Console.WriteLine(selectedUser);

                        Console.WriteLine("----------Get todos by user id----------");
                        Console.WriteLine("Select user ID to get her/his todos:");
                        var selectedUserIdForTodos = Convert.ToInt32(Console.ReadLine());

                        var todos = await jsonPlaceholderClient.GetTodoItems(selectedUserIdForTodos);

                        foreach (var todo in todos)
                        {
                            Console.WriteLine(todo);
                        }

                        Console.WriteLine("----------Get todos by user id and status----------");
                        Console.WriteLine("Select user ID to get her/his todos:");
                        var selectedUserIdForTodosWithStatus = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Select finished tasks?:");
                        var selectedCompletion = Convert.ToBoolean(Console.ReadLine().ToLower());

                        var todosByStatus = await jsonPlaceholderClient.GetTodosByStatus(selectedUserIdForTodosWithStatus, selectedCompletion);

                        foreach (var todo in todosByStatus)
                        {
                            Console.WriteLine(todo);
                        }*/

            // -------------------Github APP------------------------------

            /*            var githubClient = serviceProvider.GetService<IGithubClient>();

                        Console.WriteLine("----------Get all posts----------");

                        var posts = await jsonPlaceholderClient.GetPosts();

                        foreach (var postResponseModel in posts)
                        {
                            Console.WriteLine(postResponseModel);
                        }

                        Console.WriteLine("----------Single post return----------");

                        var post = await jsonPlaceholderClient.GetPost(5);

                        Console.WriteLine(post);

                        Console.WriteLine("----------Github----------");

                        var ginpus = await githubClient.GetUser("ginpus");

                        Console.WriteLine(ginpus);*/
        }
    }
}