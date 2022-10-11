using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Volo.Abp.Account;
using Volo.Abp.DependencyInjection;

namespace ABC.TeachOnline.Controllers
{
    [Dependency(ReplaceServices = true)]
    [ExposeServices(typeof(AccountController))]
    public class MyAccountController : AccountController
    {
        public MyAccountController(IAccountAppService accountAppService)
            : base(accountAppService)
        {
        }

        [Route("send-password-reset-code2 ")]
        public override async Task SendPasswordResetCodeAsync(SendPasswordResetCodeDto input)
        {
            Logger.LogInformation("Your custom logic...");

            await base.SendPasswordResetCodeAsync(input);
        }
    }
}