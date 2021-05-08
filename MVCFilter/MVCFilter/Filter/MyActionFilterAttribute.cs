using System;
using System.Web.Mvc;

namespace MVCFilter
{
    public class MyActionFilterAttribute : ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            //1、获取请求的类名和方法名
            string strController = filterContext.RouteData.Values["controller"].ToString();
            string strAction = filterContext.RouteData.Values["action"].ToString();
 
            //2、用另一种方式获取请求的类名和方法名
            string strController2 = filterContext.ActionDescriptor.ControllerDescriptor.ControllerName;
            string strAction2 = filterContext.ActionDescriptor.ActionName;
 
            filterContext.HttpContext.Response.Write("控制器：" + strController + "<br/>");
            filterContext.HttpContext.Response.Write("控制器：" + strController2 + "<br/>");
            filterContext.HttpContext.Response.Write("Action：" + strAction + "<br/>");
            filterContext.HttpContext.Response.Write("Action：" + strAction2 + "<br/>");
 
            filterContext.HttpContext.Response.Write("Action执行前：" + DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss fff") + "<br/>");
            base.OnActionExecuting(filterContext);
        }
 
        public override void OnActionExecuted(ActionExecutedContext filterContext)
        {
            filterContext.HttpContext.Response.Write("Action执行后：" + DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss fff") + "<br/>");
            base.OnActionExecuted(filterContext);
        }
    }
}