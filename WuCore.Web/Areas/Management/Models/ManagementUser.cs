using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WuCore.Db.Service.Models;

namespace WuCore.Web.Areas.Management.Models
{
    public class ManagementUser:User
    {
        //public ManagementUser()
        //{
        //    this.UserType = typeof(ManagementUser);
        //}

        public virtual string Child { get; set; }

        public virtual string  SameTest { get; set; }
    }
}