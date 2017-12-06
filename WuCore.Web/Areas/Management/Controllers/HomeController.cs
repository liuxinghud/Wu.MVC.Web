using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WuCore.Areas.Management.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {
        // GET: Management/Home
        public ActionResult Index()
        {
            return View();
        }
    }
}