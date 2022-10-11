using System;
using IdentityServer4.Models;
using Microsoft.AspNetCore.Mvc;
using static System.Net.WebRequestMethods;

namespace ABC.TeachOnline.Bases
{
    public class BaseResponse
    {
        public BaseResponse()
        {
        }

        const int ERROR = 7, SUCCESS = 0;


        private static JsonResult Result<T>(int code, T data, string msg)
        {
            ApiResult<T> response = new ApiResult<T>();
            response.Code = code;
            response.Msg = msg;
            response.Data = data;
            return new JsonResult(response);
        }

        private static JsonResult Result(int code, string msg)
        {
            ApiResult response = new ApiResult();
            response.Code = code;
            response.Msg = msg;
            return new JsonResult(response);
        }

        public static ActionResult Ok()
        {
            return Result(SUCCESS, "操作成功");
        }

        public static ActionResult OkWithMessage(string message)
        {
            return Result(SUCCESS, message);
        }

        public static ActionResult OkWithData<T>(T data)
        {
            return Result(SUCCESS, data, "查询成功");
        }

        public static ActionResult OkWithDetailed<T>(T data, string message)
        {
            return Result(SUCCESS, data, message);
        }

        public static ActionResult Fail()
        {
            return Result(ERROR, "操作失败");
        }

        public static ActionResult FailWithMessage(string message)
        {
            return Result(ERROR, message);
        }

        public static ActionResult FailWithDetailed<T>(T data, string message)
        {
            return Result(ERROR, data, message);
        }
    }
}

