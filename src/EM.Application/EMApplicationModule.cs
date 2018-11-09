using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using EM.Authorization;

namespace EM
{
    [DependsOn(
        typeof(EMCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class EMApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<EMAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(EMApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddProfiles(thisAssembly)
            );
        }
    }
}
