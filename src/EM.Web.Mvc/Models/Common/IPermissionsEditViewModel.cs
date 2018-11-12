using System.Collections.Generic;
using EM.Roles.Dto;

namespace EM.Web.Models.Common
{
   public interface IPermissionsEditViewModel
   {
      List<FlatPermissionDto> Permissions { get; set; }
   }
}