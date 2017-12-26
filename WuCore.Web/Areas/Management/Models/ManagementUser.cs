using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WuCore.Db.Service.Models;
using WuCore.Web.Areas.Portal.Models;

namespace WuCore.Web.Areas.Management.Models
{
    public class ManagementUser:User
    {
        public virtual IList<Student> Children { get; set; }

    }
}