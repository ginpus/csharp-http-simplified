using csharp_http_simplified.Models.Github.ResponseModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_http_simplified
{
    public interface IGithubClient
    {
        Task<UserResponseModel> GetUser(string username);
    }
}