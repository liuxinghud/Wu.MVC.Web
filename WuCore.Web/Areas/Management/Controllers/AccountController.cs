using Microsoft.AspNet.Identity;
using Microsoft.Owin.Security;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Web;
using System.Web.Mvc;
using WuCore.Web.Areas.Management.Models;
using WuCore.Web.Areas.Management.Service;

namespace WuCore.Areas.Management
{
    public class AccountController : Controller
    {

        public UserService UserService { get; set; }
        // GET: Management/Account
       public ActionResult LogIn()
        {
            if (HttpContext.User.Identity.IsAuthenticated)
            {
                return View("Error", new string[] { "您已经登录！" });
            }
            //  var a=   UserService.GetUse();
            return View();
        }

        [HttpPost]
        public ActionResult LogIn(string username, string password, string ReturnUrl)
        {
            var user = UserService.GetUser(username);
            if (user!=null)
            {

                var a = Newtonsoft.Json.JsonConvert.SerializeObject(user);


                var auth = HttpContext.GetOwinContext().Authentication;
           

               ClaimsIdentity ci = new ClaimsIdentity(DefaultAuthenticationTypes.ApplicationCookie);
                ci.AddClaim(new Claim(ClaimsIdentity.DefaultNameClaimType, user.Id.ToString()));
                //  ci.AddClaim(new Claim(ClaimTypes.NameIdentifier,user.Account));
                //  ci.AddClaim(new Claim(ClaimTypes.Email,user.Email ));
                ci.AddClaim(new Claim(ClaimTypes.UserData, Newtonsoft.Json.JsonConvert.SerializeObject(user)));
                auth.SignIn(new AuthenticationProperties { IsPersistent = true, IssuedUtc = DateTime.UtcNow, ExpiresUtc = DateTime.UtcNow.AddSeconds(200), RedirectUri = Url.Action("Login", "Account", new { Area = "Management" }) }, ci);
                //  return RedirectToAction("Index", "Home");
                return Redirect(ReturnUrl);
            }
            else
            {
                return View();
            }
       
        }
    }
}