using Volo.Abp.Http.Client.IdentityModel;
using Volo.Abp.Modularity;

namespace ABC.TeachOnline.HttpApi.Client.ConsoleTestApp
{
    [DependsOn(
        typeof(TeachOnlineHttpApiClientModule),
        typeof(AbpHttpClientIdentityModelModule)
        )]
    public class TeachOnlineConsoleApiClientModule : AbpModule
    {
        
    }
}
