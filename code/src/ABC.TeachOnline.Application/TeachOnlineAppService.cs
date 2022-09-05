using System;
using System.Collections.Generic;
using System.Text;
using ABC.TeachOnline.Localization;
using Volo.Abp.Application.Services;

namespace ABC.TeachOnline
{
    /* Inherit your application services from this class.
     */
    public abstract class TeachOnlineAppService : ApplicationService
    {
        protected TeachOnlineAppService()
        {
            LocalizationResource = typeof(TeachOnlineResource);
        }
    }
}
