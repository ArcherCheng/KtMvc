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
    class CustomerRepository : EntityRepository<Customer>, ICustomerRepository
    {
        public IEnumerable<Customer> FindByName(string name)
        {
            var customers = _dbSet.Where(c => c.CustomerName.Contains(name));
            return customers;
        }
    }
}
