using ABC.TeachOnline.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace ABC.TeachOnline
{
    [DependsOn(
        typeof(TeachOnlineEntityFrameworkCoreTestModule)
        )]
    public class TeachOnlineDomainTestModule : AbpModule
    {

    }
}