using System.Collections.Generic;
using EM.Roles.Dto;
using EM.Users.Dto;

namespace EM.Web.Models.Users
{
    public class UserListViewModel
    {
        public IReadOnlyList<UserDto> Users { get; set; }

        public IReadOnlyList<RoleDto> Roles { get; set; }
    }
}
