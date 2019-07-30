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
    public class ProductService : DomainService<Product, IProductRepository>, IProductService
    {
        public ProductService(IProductRepository repository) : base(repository)
        {
        }

        public Validation AddInclude(Product product)
        {
            ProductHolding ph = new ProductHolding
            {
                ProductHoldingID = product.ProductID,
                Quantity = 0,
                ReorderLevel = 1
            };

            product.ProductHolding = ph;
            var validation = this.Add(product);
            return validation;
        }

        public void DeleteInclude(int id)
        {
            _repository.DeleteInClude(id);
        }

        public IEnumerable<Product> GetProducts(string name)
        {
            IEnumerable<Product> products;
            if (name == null || name.Length == 0)
            {
                products = _repository.FindAll();
            }
            else
            {
                products = _repository.FindByName(name);
            }
            return products;
        }

        public IEnumerable<Product> GetProducts(int id)
        {
            var product = _repository.FindById(id);
            if (product == null)
                return null;
            else
            {
                List<Product> products = new List<Product>();
                products.Add(product);
                return products;
            }
        }

        public Validation Update(int id, int quantity)
        {
            var product = _repository.FindById(id);
            var validation = ValidateExistingEntry(product);
            if (!(validation.GetRules().Count()>0))
            {
                product.ProductHolding.Quantity = quantity;
                _repository.Update(product);
            }
            return validation;
        }
    }
}
