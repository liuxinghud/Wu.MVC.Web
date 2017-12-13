using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WuCore.Web.Areas.Management.Models;

namespace WuCore.Web.Areas.Management.Mapping
{
    public class GradeMap:ClassMap<Grade>
    {
        public GradeMap()
        {
            Table("wu_stu_grade");
            Id(m => m.Id);
            Map(m => m.Name);
            Map(m => m.Description);

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