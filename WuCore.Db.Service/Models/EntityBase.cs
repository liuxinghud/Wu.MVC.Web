using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WuCore.Db.Service.Models
{
   public abstract class EntityBase<TIdentity>
    {

        public virtual TIdentity Id { get; set; }
        public virtual User CreatedBy { get; set; }

        public virtual User ModifiedBy { get; set; }
        public virtual User DeletedBy { get; set; }

        public virtual DateTime? CreatedAt { get; set; }
        public virtual DateTime? ModifiedAt { get; set; }
        public virtual DateTime? DeletedAt { get; set; }
        public virtual bool IsDeleted { get; set; }
    }
}
