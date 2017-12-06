using System;
using System.Threading.Tasks;
using Microsoft.Owin;
using Owin;
using Microsoft.Owin.Security.Cookies;
using Microsoft.AspNet.Identity;

[assembly: OwinStartup(typeof(WuCore.Startup))]

namespace WuCore
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=316888


            app.UseCookieAuthentication(new CookieAuthenticationOptions
            {
                AuthenticationType = DefaultAuthenticationTypes.ApplicationCookie,
                LoginPath = new PathString("/Management/Account/Login"),
                 ExpireTimeSpan = TimeSpan.FromMinutes(1),//过期时间
              //  AuthenticationMode=Microsoft.Owin.Security.AuthenticationMode.Passive
            });
            // Use a cookie to temporarily store information about a user logging in with a third party login provider  
            app.UseExternalSignInCookie(DefaultAuthenticationTypes.ExternalCookie);
          
            // 取消注释以下行可允许使用第三方登录提供程序登录  
            // app.UseMicrosoftAccountAuthentication(
            //   clientId: "",
            //   clientSecret: "");

            //app.UseTwitterAuthentication(  
            //   consumerKey: "",  
            //   consumerSecret: "");  

            //app.UseFacebookAuthentication(  
            //   appId: "",  
            //   appSecret: "");  

            // 支持使用 google 账户登录  
            //  app.UseGoogleAuthentication(clientId: "", clientSecret: "");


        }
    }
}
