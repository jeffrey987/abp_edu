using System;
using ABC.TeachOnline.Dtos;
using ABC.TeachOnline.Tools;
using Microsoft.AspNetCore.Mvc;
using Volo.Abp.Application.Services;

namespace ABC.TeachOnline.Bases
{
    public class BaseAppService : ApplicationService
    {
        private CaptchaTool _captchaTool;

        public BaseAppService()
        {
        }

        /// <summary>
        /// get captcha
        /// </summary>
        /// <returns></returns>
        public ActionResult PostCaptcha()
        {
            _captchaTool = new CaptchaTool();
            var model = _captchaTool.Generate();
            return BaseResponse.OkWithDetailed<SysCaptchaResponse>(
                new SysCaptchaResponse
                {
                    CaptchaId = model.Id,
                    PicPath = model.Base64,
                    CaptchaLength = model.Base64.Length,
                }, "验证码获取成功");
        }
    }
}