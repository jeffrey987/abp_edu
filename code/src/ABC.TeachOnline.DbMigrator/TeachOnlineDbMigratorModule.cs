using ABC.TeachOnline.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.BackgroundJobs;
using Volo.Abp.Modularity;

namespace ABC.TeachOnline.DbMigrator
{
    [DependsOn(
        typeof(AbpAutofacModule),
        typeof(TeachOnlineEntityFrameworkCoreDbMigrationsModule),
        typeof(TeachOnlineApplicationContractsModule)
        )]
    public class TeachOnlineDbMigratorModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            Configure<AbpBackgroundJobOptions>(options => options.IsJobExecutionEnabled = false);
        }
    }
}
