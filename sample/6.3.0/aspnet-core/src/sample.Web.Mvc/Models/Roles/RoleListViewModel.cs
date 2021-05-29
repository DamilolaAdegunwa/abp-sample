using System.Collections.Generic;
using sample.Roles.Dto;

namespace sample.Web.Models.Roles
{
    public class RoleListViewModel
    {
        public IReadOnlyList<PermissionDto> Permissions { get; set; }
    }
}
