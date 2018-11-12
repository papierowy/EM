using Abp.EntityFrameworkCore.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using Abp.Zero.EntityFrameworkCore;
using EM.EntityFrameworkCore.Seed;

namespace EM.EntityFrameworkCore
{
   [DependsOn(
      typeof(EMCoreModule),
      typeof(AbpZeroCoreEntityFrameworkCoreModule))]
   public class EMEntityFrameworkModule : AbpModule
   {
      /* Used it tests to skip dbcontext registration, in order to use in-memory database of EF Core */
      public bool SkipDbContextRegistration { get; set; }

      public bool SkipDbSeed { get; set; }

      public override void PreInitialize()
      {
         Configuration.UnitOfWork.IsTransactional = false;
         if (!SkipDbContextRegistration)
         {
            Configuration.Modules.AbpEfCore().AddDbContext<EMDbContext>(options =>
            {
               if (options.ExistingConnection != null)
               {
                  EMDbContextConfigurer.Configure(options.DbContextOptions, options.ExistingConnection);
               }
               else
               {
                  EMDbContextConfigurer.Configure(options.DbContextOptions, options.ConnectionString);
               }
            });
         }
      }

      public override void Initialize()
      {
         IocManager.RegisterAssemblyByConvention(typeof(EMEntityFrameworkModule).GetAssembly());
      }

      public override void PostInitialize()
      {
         if (!SkipDbSeed)
         {
            SeedHelper.SeedHostDb(IocManager);
         }
      }
   }
}