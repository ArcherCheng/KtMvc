using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KtMvc.Domain.Models;

namespace KtMvc.Domain.Repository
{
    public interface IOrderRepository:IRepository<Order>,IUnitOfWorkRepository
    {
        Order FindByIdRef(int id);
        IEnumerable<Order> FindByNo(string no);
    }
}
