using Castle.Windsor;
using Castle.Windsor.Installer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using WuCore.Web;

namespace WuCore
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            Db.Service.DbCollectionFactory.InitDbFactory();
            ViewEngines.Engines.Clear();
            AreaRegistration.RegisterAllAreas();
            BootstrapContainer();
            ViewEngines.Engines.Add(new CustomViewEngine());
            GlobalFilters.Filters.Add(new HandleErrorAttribute());
        }

        private void BootstrapContainer()
        {
            WuCore.Db.Service.Ioc.container = new WindsorContainer()
                 .Install(FromAssembly.InThisApplication());
            var controllerFactory = new WindsorControllerFactory(WuCore.Db.Service.Ioc.container.Kernel);
            ControllerBuilder.Current.SetControllerFactory(controllerFactory);
        }

    }
     
}
