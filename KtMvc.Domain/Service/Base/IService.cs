using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KtMvc.Domain.BizValidation;

namespace KtMvc.Domain.Service
{
    public interface IService<TEntity, IEntityRepository>
    {
        IEntityRepository DomainRepository { get; }
        TEntity Get(int id);
        IEnumerable<TEntity> GetAll();
        Validation Add(TEntity entity);
        Validation Update(TEntity entity);
        Validation Delete(int id);
    }
}
