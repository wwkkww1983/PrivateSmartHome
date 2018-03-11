﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json.Linq;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace AnJiaWebServer_V1.Controllers
{
    /// <summary>
    /// 用户主动登出
    /// </summary>
   // [Authorize]
    [Route("api/[controller]")]
    public class SignOutController : Controller//注销登录操作
    {

        // DELETE api/values/5
        [HttpDelete("{username}")]
        public JObject Delete(string username)
        {
            #region 注销检测
            string token = JwtManager.GetRequestTokenString(Request);
            var redis = RedisHelper.GetRedisHelper();
            if (!redis.SignInCheck(token))
            {
                return null;//返回错误信息提示重新登录
            }
            #endregion

            #region 业务逻辑

            redis.DeleteKey(username);//删除用户的Token关联
            #endregion

            return null;

        }
    }
}