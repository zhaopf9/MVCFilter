using System;
using System.Web.Mvc;

namespace MVCFilter
{
    public class MyResultFilterAttribute : ActionFilterAttribute
    {
        /// <summary>
        /// 加载“视图”前执行
        /// </summary>
        /// <param name="filterContext"></param>
        public override void OnResultExecuting(ResultExecutingContext filterContext)
        {
            filterContext.HttpContext.Response.Write("加载视图前执行 OnResultExecuting" + DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss fff") + "<br/>");
            base.OnResultExecuting(filterContext);
        }

        /// <summary>
        /// 加载“视图”后执行
        /// </summary>
        /// <param name="filterContext"></param>
        public override void OnResultExecuted(ResultExecutedContext filterContext)
        {
            filterContext.HttpContext.Response.Write("加载视图后执行 OnResultExecuted" + DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss fff") + "<br/>");
            base.OnResultExecuted(filterContext);
        }
    }
}