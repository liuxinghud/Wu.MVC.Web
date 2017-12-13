using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WuCore.Db.Service.Mapping
{
    public class SubclassMapBase<T>: SubclassMap<T>
    {
        readonly MappingProviderStore providers;
        public SubclassMapBase() : this(new MappingProviderStore()) { }

        public SubclassMapBase(MappingProviderStore providers) : base(providers)
        {
            this.providers = providers;
        }

        public MappingProviderStore Providers { get { return providers; } }

        public MappingProviderStore Store { get { return providers; } }
    }
}
