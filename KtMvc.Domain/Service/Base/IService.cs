using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KtMvc.Domain.BizValidation;

namespace KtMvc.Domain.Service
{
    public interface IService<T, TRepository>
    {
        TRepository DomainRepository { get; }
        T Get(int id);
        IEnumerable<T> GetAll();
        Validation Add(T entity);
        Validation Update(T entity);
        Validation Delete(int id);
    }
}
