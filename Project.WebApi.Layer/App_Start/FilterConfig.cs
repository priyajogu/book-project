﻿using System.Web;
using System.Web.Mvc;

namespace Project.WebApi.Layer
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
