using System.Collections.Generic;
using sample.Roles.Dto;

namespace sample.Web.Models.Common
{
    public interface IPermissionsEditViewModel
    {
        List<FlatPermissionDto> Permissions { get; set; }
    }
}