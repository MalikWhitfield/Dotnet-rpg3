using System;
using System.Threading.Tasks;
using Dotnet_rpg3.Models;

namespace Dotnet_rpg3.Data
{
    public interface IAuthRepository
    {
        Task<ServiceResponse<Guid>> Register(User user, string password);

        Task<ServiceResponse<string>> Login(string username, string password);
        Task<bool> UserExists(string username);
    }
}