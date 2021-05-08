﻿using System.Web;
using System.Web.Mvc;

namespace MVCFilter
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            //filters.Add(new HandleErrorAttribute());
            filters.Add(new MyActionFilterAttribute());
            filters.Add(new MyResultFilterAttribute());
            filters.Add(new MyHandleErrorAttribute());
        }
    }
}
