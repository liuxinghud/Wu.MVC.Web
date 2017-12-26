using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WuCore.Db.Service.Models;
using WuCore.Web.Areas.Management.Models;
using Newtonsoft.Json;
namespace WuCore.Web.Areas.Portal.Models
{
    public class Student:User
    {
    
        public virtual StuClass StuClass { get; set; }

        [Newtonsoft.Json.JsonIgnore]
       public virtual ManagementUser StuParent { get; set; }

    }
}