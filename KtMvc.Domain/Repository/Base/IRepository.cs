using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KtMvc.Domain.Repository
{
    public interface IRepository<T>
    {
        T FindById(int id);
        IEnumerable<T> FindAll();
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}
