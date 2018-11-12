using Abp.Authorization;
using Abp.Localization;
using Abp.MultiTenancy;

namespace EM.Authorization
{
   public class EMAuthorizationProvider : AuthorizationProvider
   {
      public override void SetPermissions(IPermissionDefinitionContext context)
      {
         context.CreatePermission(PermissionNames.PagesUsers, L("Users"));
         context.CreatePermission(PermissionNames.PagesRoles, L("Roles"));
         context.CreatePermission(PermissionNames.PagesTenants, L("Tenants"),
            multiTenancySides: MultiTenancySides.Host);
      }

      private static ILocalizableString L(string name)
      {
         return new LocalizableString(name, EMConsts.LocalizationSourceName);
      }
   }
}