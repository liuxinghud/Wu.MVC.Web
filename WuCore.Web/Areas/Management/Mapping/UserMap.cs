using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WuCore.Web.Areas.Management.Models;

namespace WuCore.Web.Areas.Management.Mapping
{
    public class UserMap:ClassMap<User>
    {
        public UserMap()
        {
            Table("wu_account_user");
            Id(m => m.Id);
            Map(m => m.UserName);
        }
    }
}