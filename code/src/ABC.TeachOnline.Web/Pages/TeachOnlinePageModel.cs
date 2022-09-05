using ABC.TeachOnline.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace ABC.TeachOnline.Web.Pages
{
    /* Inherit your PageModel classes from this class.
     */
    public abstract class TeachOnlinePageModel : AbpPageModel
    {
        protected TeachOnlinePageModel()
        {
            LocalizationResourceType = typeof(TeachOnlineResource);
        }
    }
}