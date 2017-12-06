using System.Web.Mvc;

namespace WuCore.Areas.Portal
{
    public class PortalAreaRegistration : AreaRegistration 
    {
        private string ns = System.Reflection.MethodBase.GetCurrentMethod().DeclaringType.Namespace;
        public override string AreaName 
        {
            get 
            {
                return "Portal";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            context.MapRoute(
                "Portal_default",
                "Portal/{controller}/{action}/{id}",
                new { action = "Index", id = UrlParameter.Optional },
                new string[] { ns, $"{ns}.Controllers" }
            );

            context.MapRoute(
                "Portal",
                "Portal",
                new { controller = "Home", action = "Index", id = UrlParameter.Optional, Areas = "Portal" },
                new string[] { ns, $"{ns}.Controllers" }
            );
        }
    }
}