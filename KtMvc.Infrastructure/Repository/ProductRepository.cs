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
    public class ProductRepository : EntityRepository<Product>, IProductRepository
    {
        public void DeleteInClude(int id)
        {
            var product = FindByIdIncludePH(id);
            if(product != null)
            {
                this.Delete(product);
            }
        }

        public Product FindByIdIncludePH(int id)
        {
            var products = _dbSet.Where(x => x.ProductID == id).Include("ProductHolding").SingleOrDefault();
            return products;
        }

        public IEnumerable<Product> FindByName(string name)
        {
            var products = _dbSet.Where(x => x.ProductName.Contains(name));
            return products;
        }

        public IEnumerable<Product> ProductsAdjustment()
        {
            IEnumerable<Product> products = _dbSet.Where(x => x.ProductHolding.Quantity < x.ProductHolding.ReorderLevel);
            return products;
        }
    }
}
