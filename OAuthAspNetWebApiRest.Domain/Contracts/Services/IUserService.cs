using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;
using OAuthAspNetWebApiRest.Domain.Models;

namespace OAuthAspNetWebApiRest.Domain.Contracts.Services
{
    public interface IUserService
    {
        Task<User> FindAsync(UserLoginInfo userLoginInfo);
        Task<User> FindByIdAsync(string id);
        Task<IdentityResult> AddPasswordAsync(string id, string newPassword);
        Task<IdentityResult> AddLoginAsync(string id, UserLoginInfo userLoginInfo);
        Task<IdentityResult> ChangePasswordAsync(string id, string oldPassword, string newPassword);
        Task<IdentityResult> CreateAsync(User user, string password);
        Task<IdentityResult> CreateAsync(User user);
        Task<ClaimsIdentity> GenerateUserIdentityAsync(User user, string authenticationType);
        Task<IdentityResult> RemovePasswordAsync(string id);
        Task<IdentityResult> RemoveLoginAsync(string id, UserLoginInfo userLoginInfo);
        void Dispose();
    }
}
