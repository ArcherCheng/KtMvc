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
    public interface IProductService : IService<Product, IProductRepository>
    {
        IEnumerable<Product> GetProducts(string name);
        IEnumerable<Product> GetProducts(int id);

        Validation AddInclude(Product product);
        Validation Update(int id, int quantity);
        void DeleteInclude(int id);
    }
}
