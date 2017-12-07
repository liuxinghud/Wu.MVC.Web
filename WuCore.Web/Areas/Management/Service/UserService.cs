using NHibernate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WuCore.Db.Service.Repository;
using WuCore.Web.Areas.Management.Models;

namespace WuCore.Web.Areas.Management.Service
{

    
    public class UserService
    {
        public IRepository<User> Repository { get; set; }
        public int GetUse()
        {
           var us= Repository.List();
            return 1;
           // return TestRepository.Member<User>();
        }
    }
}