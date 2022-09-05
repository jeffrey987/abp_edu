using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using ABC.TeachOnline.Data;
using Volo.Abp.DependencyInjection;

namespace ABC.TeachOnline.EntityFrameworkCore
{
    public class EntityFrameworkCoreTeachOnlineDbSchemaMigrator
        : ITeachOnlineDbSchemaMigrator, ITransientDependency
    {
        private readonly IServiceProvider _serviceProvider;

        public EntityFrameworkCoreTeachOnlineDbSchemaMigrator(
            IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        public async Task MigrateAsync()
        {
            /* We intentionally resolving the TeachOnlineMigrationsDbContext
             * from IServiceProvider (instead of directly injecting it)
             * to properly get the connection string of the current tenant in the
             * current scope.
             */

            await _serviceProvider
                .GetRequiredService<TeachOnlineMigrationsDbContext>()
                .Database
                .MigrateAsync();
        }
    }
}