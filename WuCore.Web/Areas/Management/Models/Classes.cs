using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WuCore.Db.Service.Models;
using Newtonsoft.Json.Converters;
namespace WuCore.Web.Areas.Management.Models
{
    public class StuClass:EntityBase<int>
    {
        public virtual string Name { get; set; }

        public virtual string Description { get; set; }

        [Newtonsoft.Json.JsonIgnore]
        public virtual Grade Grade { get; set; }
        public virtual int StuCounts { get; set; }

    }
}