﻿using System.Web;
using System.Web.Mvc;

namespace AzureB2C.Sample
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
