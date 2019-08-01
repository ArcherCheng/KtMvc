using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KtMvc.Domain.BizValidation;

namespace KtMvc.Domain.Models
{
    public abstract class EntityBase<Type> : IEqualityComparer<EntityBase<Type>>
    {
        public Type EntityId { get; set; }

        public bool Equals(EntityBase<Type> x, EntityBase<Type> y)
        {
            return x.EntityId.ToString() == y.EntityId.ToString();
        }

        public int GetHashCode(EntityBase<Type> obj)
        {
            if (obj == null)
            {
                return 0;
            }
            else
            {
                return obj.EntityId.GetHashCode();
            }
        }

        public abstract Validation Validate(); 
    }
}
