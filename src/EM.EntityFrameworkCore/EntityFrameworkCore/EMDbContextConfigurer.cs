using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace EM.EntityFrameworkCore
{
    public static class EMDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<EMDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<EMDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
