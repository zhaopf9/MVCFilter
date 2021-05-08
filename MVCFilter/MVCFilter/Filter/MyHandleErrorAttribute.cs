using System;
using System.Web.Mvc;

namespace MVCFilter
{
    /// <summary>
    /// 异常处理过滤器
    /// </summary>
    public class MyHandleErrorAttribute : HandleErrorAttribute
    {
        public override void OnException(ExceptionContext filterContext)
        {
            //1、获取异常对象
            Exception ex = filterContext.Exception;

            //2、记录异常日志

            //3、重定向友好页面
            filterContext.Result = new RedirectResult("~/Error.html");

            //4、标记异常已经处理完毕
            filterContext.ExceptionHandled = true;

            base.OnException(filterContext);
        }
    }
}