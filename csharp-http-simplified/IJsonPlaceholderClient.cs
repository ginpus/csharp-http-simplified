using csharp_http_simplified.Models.JsonPlaceholder.ReadModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_http_simplified
{
    internal interface IJsonPlaceholderClient
    {
        Task<IEnumerable<PostResponseModel>> GetPosts();

        Task<PostResponseModel> GetPost(int id);

        Task<IEnumerable<GetUsers>> GetUsers();

        Task<GetUsers> GetUser(int id);

        Task<IEnumerable<GetTodos>> GetTodoItems(int userId);

        Task<IEnumerable<GetTodos>> GetTodosByStatus(int userId, bool isCompleted);
    }
}