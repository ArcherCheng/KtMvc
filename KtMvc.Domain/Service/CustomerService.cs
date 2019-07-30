using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KtMvc.Domain.Models;
using KtMvc.Domain.Repository;

namespace KtMvc.Domain.Service
{
    public class CustomerService : DomainService<Customer, ICustomerRepository>, ICustomerService
    {
        public CustomerService(ICustomerRepository repository) : base(repository)
        {
        }

        public IEnumerable<Customer> GetCustomers(string name)
        {
            IEnumerable<Customer> customers;
            if(name==null || name.Length==0)
            {
                customers = _repository.FindAll();
            }
            else
            {
                customers = _repository.FindByName(name);
            }
            return customers;
        }
    }
}
