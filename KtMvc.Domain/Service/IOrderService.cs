using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KtMvc.Domain.Models;
using KtMvc.Domain.Repository;
using KtMvc.Domain.BizValidation;

namespace KtMvc.Domain.Service
{
    public interface IOrderService : IService<Order,IOrderRepository>
    {
        Validation AddOrder(Order order);
        Validation AddOrderLine(OrderLine orderLine, IProductService productService);
        Validation UpdateOrderLine(int orderId, int orderLineid, int quantity);
        Validation DeleteOrderLine(int OrderId, int orderLineid);

        IEnumerable<Order> GetOrders(string no);
        
    }
}
