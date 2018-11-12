using Abp.Modules;
using Abp.Reflection.Extensions;
using Abp.Timing;
using Abp.Zero;
using Abp.Zero.Configuration;
using EM.Authorization.Roles;
using EM.Authorization.Users;
using EM.Configuration;
using EM.Localization;
using EM.MultiTenancy;
using EM.Timing;

namespace EM
{
   [DependsOn(typeof(AbpZeroCoreModule))]
   public class EMCoreModule : AbpModule
   {
      public override void PreInitialize()
      {
         Configuration.Auditing.IsEnabledForAnonymousUsers = true;

         // Declare entity types
         Configuration.Modules.Zero().EntityTypes.Tenant = typeof(Tenant);
         Configuration.Modules.Zero().EntityTypes.Role = typeof(Role);
         Configuration.Modules.Zero().EntityTypes.User = typeof(User);

         EMLocalizationConfigurer.Configure(Configuration.Localization);

         // Enable this line to create a multi-tenant application.
         Configuration.MultiTenancy.IsEnabled = EMConsts.MultiTenancyEnabled;

         // Configure roles
         AppRoleConfig.Configure(Configuration.Modules.Zero().RoleManagement);

         Configuration.Settings.Providers.Add<AppSettingProvider>();
      }

      public override void Initialize()
      {
         IocManager.RegisterAssemblyByConvention(typeof(EMCoreModule).GetAssembly());
      }

      public override void PostInitialize()
      {
         IocManager.Resolve<AppTimes>().StartupTime = Clock.Now;
      }
   }
}