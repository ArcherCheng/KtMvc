using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KtMvc.Domain.BizValidation;
using KtMvc.Domain.Models;

namespace KtMvc.Application.Service
{
    public interface IOrderAService:IApplicationService<Order>
    {
        Validation CreateOrder(Order entity);
        Validation AppendOrderLine(OrderLine entity);
        Validation EditOrderLine(int orderid, int orderlineid, int quantity);
        Validation RemoveOrderLine(int orderid, int orderlineid);

        IEnumerable<Order> GetOrders(string no);

    }
}
