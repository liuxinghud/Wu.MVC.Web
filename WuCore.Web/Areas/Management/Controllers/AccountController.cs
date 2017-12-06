using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WuCore.Web.Areas.Management.Service;

namespace WuCore.Areas.Management
{
    public class AccountController : Controller
    {

        public UserService UserService { get; set; }
        // GET: Management/Account
       public ActionResult LogIn()
        {

         var a=   UserService.GetUse();
            return View();
        }
    }
}