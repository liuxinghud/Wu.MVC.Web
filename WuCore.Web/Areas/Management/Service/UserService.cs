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

        public TestRepository TestRepository { get; set; }
        public int GetUse()
        {
            return TestRepository.Member<User>();
        }
    }
}