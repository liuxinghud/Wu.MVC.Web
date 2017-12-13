﻿using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WuCore.Db.Service.Mapping;
using WuCore.Db.Service.Models;
using WuCore.Web.Areas.Portal.Models;

namespace WuCore.Web.Areas.Portal.Mapping
{
    public class StudentMap :SubclassMap<Student> //SubclassMapBase<Student>
    {
        public StudentMap()
        {
            base.DiscriminatorValue(typeof(Student).FullName);
            // DiscriminatorValue(2);
             Table("wu_account_user");
            Map(m => m.SameTest);
            References(m => m.StuClass).Column("StuClass");
          References(m => m.StuParent).Column("StuParent");
        }

    }
}