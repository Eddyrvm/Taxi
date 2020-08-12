using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Taxi.Web.Data.Entities;

namespace Taxi.Web.Helpers
{
    public class UserHelper : IUserHelper
    {
        private readonly UserManager<UserEntity> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;

        public UserHelper(UserManager<UserEntity> userManager,
            RoleManager<IdentityRole> roleManager)
        {
            _userManager = userManager;
            _roleManager = roleManager;
        }

        public Task<IdentityResult> AddUserAsync(UserEntity user, string password)
        {
            throw new NotImplementedException();
        }

        public Task AddUserToRoleAsync(UserEntity user, string roleName)
        {
            throw new NotImplementedException();
        }

        public Task CheckRoleAsync(string roleName)
        {
            throw new NotImplementedException();
        }

        public Task<UserEntity> GetUserByEmailAsync(string email)
        {
            throw new NotImplementedException();
        }

        public Task<bool> IsUserInRoleAsync(UserEntity user, string roleName)
        {
            throw new NotImplementedException();
        }
    }
}
