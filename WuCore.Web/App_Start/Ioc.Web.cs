using Castle.MicroKernel.Registration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Castle.MicroKernel.SubSystems.Configuration;
using Castle.Windsor;
using System.Web.Mvc;

namespace WuCore.Web
{
    public partial class Ioc : IWindsorInstaller
    {
        public void Install(IWindsorContainer container, IConfigurationStore store)
        {

            container.Register(Classes.FromAssemblyInThisApplication()
                            .BasedOn<IController>()
                          .LifestyleTransient());//临时的

            //var h = Classes.FromThisAssembly().Where(x => x.FullName.EndsWith("Service"));

            // var h2 = Classes.FromAssemblyInThisApplication().Where(x => x.AssemblyQualifiedName.EndsWith("Service"));

            container.Register(Classes.FromThisAssembly().Where(x => x.FullName.EndsWith("Service"))
                .WithService.AllInterfaces()//.DefaultInterfaces()
               .LifestylePerWebRequest()
               .AllowMultipleMatches()
                );

        }
    }
}