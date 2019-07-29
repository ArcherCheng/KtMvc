using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KtMvc.Domain.Models;

namespace KtMvc.Domain.Repository
{
    public interface ICustomerRepository: IRepository<Customer>,IUnitOfWorkRepository
    {
        IEnumerable<Customer> FindByName(string name);
    }
}
