using System;
using System.Web.Mvc;

namespace MVCFilter
{
   /// <summary>
    /// 授权过滤器
    /// </summary>
    public class MyAuthorizeAttribute : AuthorizeAttribute
    {
        public override void OnAuthorization(AuthorizationContext filterContext)
        {
            filterContext.HttpContext.Response.Write("OnAuthorization<br/>");
 
            //注释掉父类方法，因为父类里的OnAuthorization方法会调用ASP.NET的授权验证机制
            //base.OnAuthorization(filterContext);
        }
 
    }
}