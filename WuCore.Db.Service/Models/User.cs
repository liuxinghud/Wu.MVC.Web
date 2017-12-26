using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WuCore.Db.Service.Models
{
    public class User: EntityBase<long>
    {

        public virtual Type UserType { get; set; }

        public virtual string UserName { get; set; }

        public virtual string Name { get; set; }
        [Newtonsoft.Json.JsonIgnore]
        public virtual string Password { get; set; }

        public virtual string Email { get; set; }

        public virtual string HeadImg { get; set; }



    }
}