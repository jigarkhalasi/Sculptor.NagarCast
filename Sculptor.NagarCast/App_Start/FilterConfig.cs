﻿using System.Web;
using System.Web.Mvc;

namespace Sculptor.NagarCast
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}