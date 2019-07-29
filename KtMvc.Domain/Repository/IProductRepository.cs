using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KtMvc.Domain.Models;

namespace KtMvc.Domain.Repository
{
    public interface IProductRepository : IRepository<Product>,IUnitOfWorkRepository
    {
        Product FindByIdIncludePH(int id);
        IEnumerable<Product> ProductsAdjustment();
        IEnumerable<Product> FindByName(string name);

        void DeleteInClude(int id);
    }
}
