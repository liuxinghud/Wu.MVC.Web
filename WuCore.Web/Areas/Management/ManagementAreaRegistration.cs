using System.Web.Mvc;

namespace WuCore.Areas.Management
{
    public class ManagementAreaRegistration : AreaRegistration 
    {
        private string ns = System.Reflection.MethodBase.GetCurrentMethod().DeclaringType.Namespace;
        public override string AreaName 
        {
            get 
            {
                return "Management";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {

           
            context.MapRoute(
                 "Management_default",
                 "Management/{controller}/{action}/{id}",
                 new { action = "Index", id = UrlParameter.Optional },
                 new string[] { ns, string.Concat(ns, ".Controllers") }
             );
            context.MapRoute(
                "Management",
                "Management",
                new { controller = "Home", action = "Index", id = UrlParameter.Optional, Areas = "Management" },
                new string[] { ns, string.Concat(ns, ".Controllers") }
            );
            context.MapRoute(
               "",
               "",
               new { controller = "Home", action = "Index", id = UrlParameter.Optional, Areas = "Management" },
               new string[] { ns, string.Concat(ns,".Controllers")  }
           );
        }
    }
}