using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KtMvc.Domain.Models;


namespace KtMvc.Application.Service
{
    public interface ICustomerAService : IApplicationService<Customer>
    {
        IEnumerable<Customer> GetCustomers(string name);
    }
}
