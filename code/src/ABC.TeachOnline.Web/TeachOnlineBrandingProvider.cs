using Volo.Abp.AspNetCore.Mvc.UI.Theme.Shared.Components;
using Volo.Abp.DependencyInjection;

namespace ABC.TeachOnline.Web
{
    [Dependency(ReplaceServices = true)]
    public class TeachOnlineBrandingProvider : DefaultBrandingProvider
    {
        public override string AppName => "TeachOnline";
    }
}
