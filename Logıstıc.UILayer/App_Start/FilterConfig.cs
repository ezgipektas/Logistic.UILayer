﻿using System.Web;
using System.Web.Mvc;

namespace Logıstıc.UILayer
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
