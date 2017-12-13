using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WuCore.Db.Service.Models;

namespace WuCore.Web.Areas.Management.Models
{
    public class Grade:EntityBase<int>
    {
        public virtual string Name { get; set; }

        public virtual string Description { get; set; }
    }
}