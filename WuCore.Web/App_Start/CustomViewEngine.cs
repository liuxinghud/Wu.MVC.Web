using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WuCore
{
    public  class CustomViewEngine : RazorViewEngine
    {

        private readonly Dictionary<string, string[]> MyViewLocations = new Dictionary<string, string[]>();
        
        public CustomViewEngine()
        {
            //MyViewLocations.Add("DispatcherPortal", new[] { "~/Modules/Dispatcher/Areas/{2}/Views/{1}/{0}.cshtml", "~/Modules/Dispatcher/Areas/{2}/Views/Shared/{0}.cshtml" });
            //MyViewLocations.Add("DispatcherManagement", new[] { "~/Modules/Dispatcher/Areas/{2}/Views/{1}/{0}.cshtml", "~/Modules/Dispatcher/Areas/{2}/Views/Shared/{0}.cshtml" });
            MyViewLocations.Add("Management", new[] { "~/Areas/{2}/Views/{1}/{0}.cshtml", "~/Areas/{2}/Views/Shared/{0}.cshtml" });
            MyViewLocations.Add("Portal", new[] { "~/Areas/{2}/Views/{1}/{0}.cshtml", "~/Areas/{2}/Views/Shared/{0}.cshtml" });


        }

        public override ViewEngineResult FindView(ControllerContext controllerContext, string viewName, string masterName, bool useCache)
        {
            if (MyViewLocations.TryGetValue(controllerContext.RouteData.DataTokens["area"] as string, out string[] viewpath))
            {
                ViewLocationFormats = AreaViewLocationFormats = AreaMasterLocationFormats = AreaPartialViewLocationFormats = viewpath;
            }
            else
            {
                ViewLocationFormats = AreaViewLocationFormats = AreaMasterLocationFormats = AreaPartialViewLocationFormats = new string[] { "~/Areas/{2}/Views/{1}/{0}.cshtml", "~/Areas/{2}/Views/Shared/{0}.cshtml" };
              //  throw new KeyNotFoundException("注册区域失败:未找到AreaName，请确认路由是否配置。");
            }
            return base.FindView(controllerContext, viewName, masterName, useCache);
        }

    }
}