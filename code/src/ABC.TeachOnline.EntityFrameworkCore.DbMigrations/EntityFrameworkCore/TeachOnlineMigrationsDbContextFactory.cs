using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace ABC.TeachOnline.EntityFrameworkCore
{
    /* This class is needed for EF Core console commands
     * (like Add-Migration and Update-Database commands) */
    public class TeachOnlineMigrationsDbContextFactory : IDesignTimeDbContextFactory<TeachOnlineMigrationsDbContext>
    {
        public TeachOnlineMigrationsDbContext CreateDbContext(string[] args)
        {
            TeachOnlineEfCoreEntityExtensionMappings.Configure();

            var configuration = BuildConfiguration();

            var builder = new DbContextOptionsBuilder<TeachOnlineMigrationsDbContext>()
                .UseMySql(configuration.GetConnectionString("Default"));

            return new TeachOnlineMigrationsDbContext(builder.Options);
        }

        private static IConfigurationRoot BuildConfiguration()
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(Path.Combine(Directory.GetCurrentDirectory(), "../ABC.TeachOnline.DbMigrator/"))
                .AddJsonFile("appsettings.json", optional: false);

            return builder.Build();
        }
    }
}
