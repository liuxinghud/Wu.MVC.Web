using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WuCore.Web.Areas.Management.Service;

namespace WuCore.Web.Areas.Portal.Controllers
{
    public class MemberShipController : Controller
    {
       // private static WebServerClient _webServerClient;
        private static string _accessToken;
        public UserService UserService { get; set; }
        public ActionResult PortalLogIn(string username,string password)
        {
         var user=UserService.GetUser(username);
            if (user!=null)
            {


            }

            return Json(null);
        }

    }
}