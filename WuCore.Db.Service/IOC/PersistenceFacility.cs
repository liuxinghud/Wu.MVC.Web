using Castle.MicroKernel.Facilities;
using Castle.MicroKernel.Registration;
using FluentNHibernate.Automapping;
using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using NHibernate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace WuCore.Db.Service
{
    public class PersistenceFacility : AbstractFacility
    {
        private const string MysqlDbFactory = "MysqlDbFactory";
        private const string MssqlDbFactory = "MssqlDbFactory";
        private const string MysqlConnect = "MysqlConnect";
        private const string MssqlConnect = "MssqlConnect";
       // private static ISessionFactory sessionFactory;
        protected override void Init()
        {

            Kernel.Register(
             Component.For<ISessionFactory>()
                 .UsingFactoryMethod(DbCollectionFactory.CreateMysqlFactory)
                 .LifeStyle
                 .Singleton
                 .Named(MysqlDbFactory)
                 ,
         Component.For<ISessionFactory>()
             .UsingFactoryMethod(DbCollectionFactory.CreateMSSQLFactory)
             .LifeStyle
             .Singleton
             .Named(MssqlDbFactory)
         );

            Kernel.Register(
                Component.For<ISession>()
                    .UsingFactoryMethod(kernel => kernel.Resolve<ISessionFactory>(MysqlDbFactory).OpenSession())
                    .LifeStyle
                    .PerWebRequest
                    .Named(MysqlConnect)
                    ,
            Component.For<ISession>()
                .UsingFactoryMethod(kernel => kernel.Resolve<ISessionFactory>(MssqlDbFactory).OpenSession())
                .LifeStyle
                .PerWebRequest
                .Named(MssqlConnect)
            );
        }
         








      
    }
}
