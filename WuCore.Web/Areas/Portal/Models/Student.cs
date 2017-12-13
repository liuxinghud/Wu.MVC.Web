using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WuCore.Db.Service.Models;
using WuCore.Web.Areas.Management.Models;

namespace WuCore.Web.Areas.Portal.Models
{
    public class Student:User
    {
        public Student()
        {
            this.UserType = typeof(Student);
        }
        public virtual StuClass StuClass { get; set; }

       public virtual ManagementUser StuParent { get; set; }
        public virtual string SameTest { get; set; }

    }
}