using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WuCore.Db.Service.Mapping;
using WuCore.Db.Service.Models;
using WuCore.Web.Areas.Management.Models;

namespace WuCore.Web.Areas.Management.Mapping
{
    public class ManagementUserMap :SubclassMap<ManagementUser> //SubclassMapBase<ManagementUser>
    {
        public ManagementUserMap()
        {
            // DiscriminatorValue(1);
         base.DiscriminatorValue(typeof(ManagementUser).FullName);
            Table("wu_account_user");
            Map(x => x.Child);
            Map(m => m.SameTest);
        }

    }
}