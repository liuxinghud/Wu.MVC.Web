using Castle.MicroKernel.Registration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Castle.MicroKernel.SubSystems.Configuration;
using Castle.Windsor;
using System.Web.Mvc;
using WuCore.Db.Service.Repository;

namespace WuCore.Db.Service
{
    public partial class Ioc : IWindsorInstaller
    {
        public static IWindsorContainer container { get; set; }
        public void Install(IWindsorContainer container, IConfigurationStore store)
        {
            container.AddFacility(new PersistenceFacility());
            container.Register(Classes.FromThisAssembly().Where(x => x.FullName.EndsWith("Service") || x.FullName.EndsWith("Repository"))
                .WithService.AllInterfaces()//.DefaultInterfaces()
               .LifestylePerWebRequest()
               .AllowMultipleMatches()
                );
            container.Register(Component.For(typeof(IRepository<>)).ImplementedBy(typeof(Repository<>)).LifestylePerWebRequest());

            //container.Register(Classes.FromThisAssembly().InSameNamespaceAs<Ioc>(true)
            //   .WithService.AllInterfaces()//.DefaultInterfaces()
            //   .LifestylePerWebRequest()
            //   .AllowMultipleMatches()
            //   );
        }

    }
}
