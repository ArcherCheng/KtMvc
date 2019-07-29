using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KtMvc.Domain.BizValidation;

namespace KtMvc.Domain.Models
{
    public abstract class EntityBase<T> : IEqualityComparer<EntityBase<T>>
    {
        public T EngtityId { get; set; }

        public bool Equals(EntityBase<T> x, EntityBase<T> y)
        {
            throw new NotImplementedException();
        }

        public int GetHashCode(EntityBase<T> obj)
        {
            throw new NotImplementedException();
        }

        public abstract Validation Validate(); 
    }
}
