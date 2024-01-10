using ContactWebAPI.Domain;
using ContactWebAPI.SqlServer;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyContact.SqlServer
{
    public class IdentityServerUserStore : IIdentityServerUserStore
    {
        private readonly UserManager<IdentityUser> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;


        public IdentityServerUserStore(
            UserManager<IdentityUser> userManager, RoleManager<IdentityRole> roleManager)
        {
            _userManager = userManager;
            _roleManager = roleManager;
           // _context = new ContactContext(_configuration);
        }

        public async Task<IdentityUser> FindUser(string email)
        {
            var user = await _userManager.FindByEmailAsync(email);

            return user;
        }

        public async Task<bool> CheckPassword(IdentityUser user, string password)
        {
            var isValid = await _userManager.CheckPasswordAsync(user, password);

            return isValid;
        }

        public async Task<IList<string>> GetRoles(IdentityUser user)
        {
            var roles = await _userManager.GetRolesAsync(user);

            return roles;
        }

        public async Task<IdentityResult> RegisterUser(string password, IdentityUser user)
        {
            return await _userManager.CreateAsync(user, password);
        }

        public async Task<IdentityResult> CreateRole(IdentityRole role)
        {
            return await _roleManager.CreateAsync(role);
        }

        public async Task<bool> CheckRole(string roleName)
        {
            return await _roleManager.RoleExistsAsync(roleName);
        }

        public async Task<IdentityResult> AddToRole(IdentityUser user, string roleName)
        {
            return await _userManager.AddToRoleAsync(user, "Admin");
        }
    }
}
