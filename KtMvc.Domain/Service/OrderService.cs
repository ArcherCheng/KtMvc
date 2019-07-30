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
    public class OrderService : DomainService<Order, IOrderRepository>,IOrderService
    {
        public OrderService(IOrderRepository repository) : base(repository)
        {
        }

        public Validation AddOrder(Order order)
        {
            throw new NotImplementedException();
        }

        public Validation AddOrderLine(OrderLine orderLine, IProductService productService)
        {
            throw new NotImplementedException();
        }

        public Validation DeleteOrderLine(int OrderId, int orderLineid)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Order> GetOrders(string no)
        {
            throw new NotImplementedException();
        }

        public Validation UpdateOrderLine(int orderId, int orderLineid, int quantity)
        {
            throw new NotImplementedException();
        }
    }
}
