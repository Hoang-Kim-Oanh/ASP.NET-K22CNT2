﻿using System.Web;
using System.Web.Mvc;

namespace bai2._1_hko
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}