using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WuCore.Db.Service.Models;

namespace WuCore.Db.Service.Mapping
{
    public class UserMap:ClassMap<User>
    {
        public UserMap()
        {
         
            Table("wu_account_user");
            Id(m => m.Id);
            Map(m => m.UserName);
            Map(m => m.Name);
            Map(m => m.Password);
            Map(m => m.Email);
            Map(m => m.HeadImg);
            //Map(m => m.UserType);

            Map(m => m.IsDeleted);
            Map(m => m.CreatedAt);
            Map(m => m.ModifiedAt);
            Map(m => m.DeletedAt);
            References(m => m.CreatedBy).Column("CreatedBy");
            References(m => m.ModifiedBy).Column("ModifiedBy");
            References(m => m.DeletedBy).Column("DeletedBy");
           // UseUnionSubclassForInheritanceMapping();
            DiscriminateSubClassesOnColumn("UserType");
        }
    }
}