using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.Modularity;

namespace ABC.TeachOnline.EntityFrameworkCore
{
    [DependsOn(
        typeof(TeachOnlineEntityFrameworkCoreModule)
        )]
    public class TeachOnlineEntityFrameworkCoreDbMigrationsModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            context.Services.AddAbpDbContext<TeachOnlineMigrationsDbContext>();
        }
    }
}
