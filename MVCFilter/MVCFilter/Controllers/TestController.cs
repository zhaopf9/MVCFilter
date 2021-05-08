using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCFilter.Controllers
{
    public class TestController : Controller
    {
        //[MyActionFilter]
        [MyResultFilter]
        [MyAuthorize]
        public ActionResult Index()
        {
            //int a = 0;
            //int b = 1 / a;//错误测试代码
            return View();
        }
	}
}