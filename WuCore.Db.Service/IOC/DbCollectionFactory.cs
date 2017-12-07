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
     public  class DbCollectionFactory
    {
        private static Task<ISessionFactory> sessionFactory;
        private static Task<ISessionFactory> mssqlsessionFactory;
        /// <summary>
        /// 初始化Nhibernate
        /// </summary>
        /// <param name="assembly">Mapping所在点程序集</param>
        public static void InitDbFactory(Assembly[] assembly)
        {
            sessionFactory = CreateMysqlFactoryAsync(assembly);
            mssqlsessionFactory = CreateMSSQLFactoryAsync();
        }
  
        private static async Task<ISessionFactory> CreateMysqlFactoryAsync(Assembly[] assembly)
        {
            sessionFactory = Task.Run(() =>
            {
                var cfg = Fluently.Configure().Database(MySQLConfiguration.Standard.ConnectionString(x => x.FromConnectionStringWithKey("DatabaseConnectionString")).Driver<NHibernate.Driver.MySqlDataDriver>())
                 // .Mappings(m => m.FluentMappings.AddFromAssembly(Assembly.Load("WuCore.Web")));
                  .Mappings(m =>
                   {
                       foreach (var item in assembly)
                       {
                           m.FluentMappings.AddFromAssembly(item);
                       }
                   });
                return cfg.BuildSessionFactory();
            });
            return await sessionFactory;
        }

         internal static ISessionFactory CreateMysqlFactory()
        {
            sessionFactory.Wait();
            return sessionFactory?.Result;
        }



        private static async Task<ISessionFactory> CreateMSSQLFactoryAsync()
        {
            mssqlsessionFactory = Task.Run(() =>
            {
                var cfg = Fluently.Configure().Database(MsSqlConfiguration.MsSql2008.ConnectionString(x => x.FromConnectionStringWithKey("DatabaseConnectionString")).Driver<NHibernate.Driver.MySqlDataDriver>())
               
                  .Mappings(m => m.FluentMappings.AddFromAssembly(Assembly.Load("WuCore.Web")));
                return cfg?.BuildSessionFactory();
            });
            return await mssqlsessionFactory;
        }

        internal static ISessionFactory CreateMSSQLFactory()
        {
            mssqlsessionFactory.Wait();
            return mssqlsessionFactory?.Result;
        }


    }
}
