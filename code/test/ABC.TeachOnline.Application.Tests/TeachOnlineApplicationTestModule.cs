using Volo.Abp.Modularity;

namespace ABC.TeachOnline
{
    [DependsOn(
        typeof(TeachOnlineApplicationModule),
        typeof(TeachOnlineDomainTestModule)
        )]
    public class TeachOnlineApplicationTestModule : AbpModule
    {

    }
}