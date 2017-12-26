using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Web;
using System.Web.Mvc;
using WuCore.Db.Service.Models;
using WuCore.Web.Areas.Management.Models;
using WuCore.Web.Areas.Portal.Models;

namespace WuCore.Areas.Management.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {
        // GET: Management/Home
        public ActionResult Index()
        {
            ClaimsIdentity c = HttpContext.User.Identity as ClaimsIdentity;
            if (c!=null)
            {
                var user = c.Claims.Where(x => x.Type == ClaimTypes.UserData).FirstOrDefault();
                var u1 = Newtonsoft.Json.JsonConvert.DeserializeObject<ManagementUser>(user.Value);
                if (u1 is ManagementUser)
                {
                    var children = (u1 as ManagementUser)?.Children;
                }
              //  else if (u1 is Student)
                {
                   // var parent = (u1 as Student)?.StuParent;
                }
            }
            return View();
        }
    }
}