using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using OAuthAspNetWebApiRest.Domain.Contracts.Services;
using OAuthAspNetWebApiRest.Domain.Models;
using OAuthAspNetWebApiRest.Domain.Contracts.Repostiories;

namespace OAuthAspNetWebApiRest.Domain.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;
        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }
        public Task<IdentityResult> AddLoginAsync(string id, UserLoginInfo userLoginInfo)
        {
            return _userRepository.AddLoginAsync(id, userLoginInfo);
        }

        public Task<IdentityResult> AddPasswordAsync(string id, string newPassword)
        {
            return _userRepository.AddPasswordAsync(id, newPassword);
        }

        public Task<IdentityResult> ChangePasswordAsync(string id, string oldPassword, string newPassword)
        {
            return _userRepository.ChangePasswordAsync(id, oldPassword, newPassword);
        }

        public Task<IdentityResult> CreateAsync(User user)
        {
            return _userRepository.CreateAsync(user);
        }

        public Task<IdentityResult> CreateAsync(User user, string password)
        {
            return _userRepository.CreateAsync(user, password);
        }

        public void Dispose()
        {
            _userRepository.Dispose();
        }

        public Task<User> FindAsync(UserLoginInfo userLoginInfo)
        {
            return _userRepository.FindAsync(userLoginInfo);
        }

        public Task<User> FindByIdAsync(string id)
        {
            return _userRepository.FindByIdAsync(id);
        }

        public Task<ClaimsIdentity> GenerateUserIdentityAsync(User user, string authenticationType)
        {
            return _userRepository.GenerateUserIdentityAsync(user, authenticationType);
        }

        public Task<IdentityResult> RemoveLoginAsync(string id, UserLoginInfo userLoginInfo)
        {
            return _userRepository.RemoveLoginAsync(id, userLoginInfo);
        }

        public Task<IdentityResult> RemovePasswordAsync(string id)
        {
            return _userRepository.RemovePasswordAsync(id);
        }
    }
}
