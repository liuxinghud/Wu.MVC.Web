using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WuCore.Db.Service.Models
{
   public abstract class EntityBase<TIdentity>: IEntity, IEntity<TIdentity> 
    {

        public virtual TIdentity Id { get; set; }
        object IEntity.Id { get { return Id; } set { Id = (TIdentity)value; } }
        
        [Newtonsoft.Json.JsonIgnore]
        public virtual User CreatedBy { get; set; }

        [Newtonsoft.Json.JsonIgnore]
        public virtual User ModifiedBy { get; set; }
        [Newtonsoft.Json.JsonIgnore]
        public virtual User DeletedBy { get; set; }

        public virtual DateTime? CreatedAt { get; set; }
        public virtual DateTime? ModifiedAt { get; set; }
        public virtual DateTime? DeletedAt { get; set; }
        public virtual bool IsDeleted { get; set; }
    }



    public interface IEntity
    {
        object Id { get; set; }
        User CreatedBy { get; set; }
        User ModifiedBy { get; set; }
        User DeletedBy { get; set; }

        DateTime? CreatedAt { get; set; }
        DateTime? ModifiedAt { get; set; }
        DateTime? DeletedAt { get; set; }

        bool IsDeleted { get; set; }
    }

    public interface IEntity<TIdentity> : IEntity
    {
        new TIdentity Id { get; set; }
    }
}
