using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KtMvc.Domain.BizValidation
{
    public interface IValidateSpec<TEntity> where TEntity : class
    {
        Validation Validate(TEntity entity);
    }
}
