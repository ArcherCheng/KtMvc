using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KtMvc.Domain.Repository;
using KtMvc.Domain.Models;
using System.Data.Entity;

namespace KtMvc.Infrastructure.Repository
{
    public class OrderRepository : EntityRepository<Order>, IOrderRepository
    {
        public Order FindByIdRef(int id)
        {
            var order = this.FindById(id);
            ////++++
            _db.Entry(order).Collection(o => o.OrderLines).Load();
            return order;
        }

        public IEnumerable<Order> FindByNo(string no)
        {
            var orders = _dbSet.Where(o => o.OrderNO.Contains(no));
            return orders;
        }
    }
}
