using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KtMvc.Domain.BizValidation;

namespace KtMvc.Application.Service
{
    public interface IApplicationService<TEntity>
    {
        TEntity Details(int id);
        IEnumerable<TEntity> ListAll();
        Validation Create(TEntity entity);
        Validation Update(TEntity entity);
        Validation Remove(int id);

    }
}
