using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WuCore.Web.Areas.Management.Models;

namespace WuCore.Web.Areas.Management.Mapping
{
    public class ClassesMap : ClassMap<StuClass>
    {
        public ClassesMap()
        {
          Table("wu_stu_stuclass");
            Id(m => m.Id);
            Map(m => m.Name);
            Map(m => m.Description);
            Map(m => m.StuCounts);
            References(m => m.Grade).Column("Grade");

            Map(m => m.IsDeleted);
            //Map(m => m.CreatedAt);
            //Map(m => m.ModifiedAt);
            //Map(m => m.DeletedAt);
            //References(m => m.CreatedBy).Column("CreatedBy");
            //References(m => m.ModifiedBy).Column("ModifiedBy");
            //References(m => m.DeletedBy).Column("DeletedBy");


        }
    }
}