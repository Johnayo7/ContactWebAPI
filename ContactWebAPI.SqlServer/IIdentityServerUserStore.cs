using ContactWebAPI.Domain;
using ContactWebAPI.SqlServer;
using Microsoft.AspNetCore.Identity;

namespace MyContact.SqlServer
{
    public interface IIdentityServerUserStore
    {
        Task<IdentityResult> AddToRole(IdentityUser user, string roleName);
        Task<bool> CheckPassword(IdentityUser user, string password);
        Task<bool> CheckRole(string roleName);
        Task<IdentityResult> CreateRole(IdentityRole role);
        Task<IdentityUser> FindUser(string email);
        Task<IList<string>> GetRoles(IdentityUser user);
        Task<IdentityResult> RegisterUser(string password, IdentityUser user);
    }
}