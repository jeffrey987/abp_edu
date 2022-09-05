using ABC.TeachOnline.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace ABC.TeachOnline.Controllers
{
    /* Inherit your controllers from this class.
     */
    public abstract class TeachOnlineController : AbpController
    {
        protected TeachOnlineController()
        {
            LocalizationResource = typeof(TeachOnlineResource);
        }
    }
}