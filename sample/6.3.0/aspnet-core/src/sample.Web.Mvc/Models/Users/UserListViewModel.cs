using System.Collections.Generic;
using sample.Roles.Dto;

namespace sample.Web.Models.Users
{
    public class UserListViewModel
    {
        public IReadOnlyList<RoleDto> Roles { get; set; }
    }
}
