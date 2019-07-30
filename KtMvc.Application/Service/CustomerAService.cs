using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KtMvc.Domain.BizValidation;
using KtMvc.Domain.Models;
using KtMvc.Domain.Service;
using KtMvc.Domain.Repository;


namespace KtMvc.Application.Service
{
    public class CustomerAService : ApplicationService<Customer, ICustomerRepository, ICustomerService>, ICustomerAService
    {
        public CustomerAService(ICustomerService service, IUnitOfWork unitOfWork) : base(service, unitOfWork)
        {
        }

        public IEnumerable<Customer> GetCustomers(string name)
        {
            var customers = _service.GetCustomers(name).ToList();
            if (customers.Count > 0)
                return customers;
            return null;
        }
    }
}
