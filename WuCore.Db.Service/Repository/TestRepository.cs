using NHibernate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WuCore.Db.Service.Repository
{
    public  class TestRepository
    {
        public ISession Session { get; set; }

        public int Member<T>()
        {
         var L=   Session.Query<T>().ToList();
            return L.Count();
        }
    }
}
