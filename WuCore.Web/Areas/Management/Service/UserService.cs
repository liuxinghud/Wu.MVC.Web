using NHibernate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WuCore.Db.Service.Models;
using WuCore.Db.Service.Repository;
using WuCore.Web.Areas.Management.Models;
using WuCore.Web.Areas.Portal.Models;

namespace WuCore.Web.Areas.Management.Service
{

    
    public class UserService
    {
        public IRepository<User> Repository { get; set; }
        public IRepository<Grade> GradeRps { get; set; }
        public IRepository<StuClass> ClsRps { get; set; }
        public int GetUse()
        {

            var mus= Repository.Get(x => x.UserName == "zhangsan1");
            if (mus==null)
            {
                ManagementUser u = new ManagementUser { Id = "user00002", UserName = "zhangsan1", CreatedAt = DateTime.UtcNow, Name = "张三1", Email = "8787@qq.com", Password = "abcdef", Child = "小张三" };
                Repository.Save(u);
            }


            var entity = Repository.Get(x=>x.UserName=="zhangsanson");

            Grade g = GradeRps.Get(x=>x.Name=="一年级");

            StuClass stucls = ClsRps.Get(x => x.Id == 1);

            if (stucls==null)
            {
                stucls = new StuClass { StuCounts = 30, Name = "一年级一班", Grade = g, Description = "一年一班" };
                ClsRps.Save(stucls);
            }

            if (entity==null)
            {
                //ManagementUser u = new ManagementUser { Id = "user00002", UserName = "zhangsan1", CreatedAt = DateTime.UtcNow, Name = "张三1", Email = "8787@qq.com", Password = "abcdef",Child="小张三" };
                //Repository.Save(u);





                Student stu = new Student
                {
                    Id = "stu00003",
                    UserName = "zhangsanson",
                    CreatedAt = DateTime.UtcNow,
                    Name = "张三1",
                    Email = "8787@qq.com",
                    Password = "abcdef",
                    StuParent = Repository.Get(x => x.UserName == "zhangsan1") as ManagementUser,
                    StuClass= stucls
                };
                Repository.Save(stu);
            }
            
            var m = entity is ManagementUser;

              var s=   entity is User;

            return 1;
           // return TestRepository.Member<User>();
        }
    }
}