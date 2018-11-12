using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using EM.Authorization.Roles;
using EM.Authorization.Users;
using EM.MultiTenancy;

namespace EM.EntityFrameworkCore
{
   public class EMDbContext : AbpZeroDbContext<Tenant, Role, User, EMDbContext>
   {
      /* Define a DbSet for each entity of the application */

      public EMDbContext(DbContextOptions<EMDbContext> options)
         : base(options)
      {
      }
   }
}