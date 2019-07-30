using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KtMvc.Domain.BizValidation;
using KtMvc.Domain.Models;
using KtMvc.Domain.Service;
using KtMvc.Domain.Repository;
using KtMvc.Application.Dtos;

namespace KtMvc.Application.Service
{
    class ProductAService : ApplicationService<Product, IProductRepository, IProductService>, IProductAService
    {
        public ProductAService(IProductService service, IUnitOfWork unitOfWork) : base(service, unitOfWork)
        {
        }

        public Validation CreateInclude(Product product)
        {
            _validation = _service.AddInclude(product);
            UowCommit();
            return _validation;
        }

        public IEnumerable<SearchProductResponse> GetProducts(SearchProductRequest searchProductRequest)
        {
            var searchID = searchProductRequest.SearchID;
            var searchName = searchProductRequest.SearchName;
            List<Product> products;
            if (searchID > 0)
            {
                products = _service.GetProducts(searchID).ToList();
                if (products != null)
                {
                    return ProductsToResponses(products);
                }
            }
            else
            {
                products = _service.GetProducts(searchName).ToList();
                if (products.Count > 0)
                    return ProductsToResponses(products);
            }
            return null;
        }

        public IEnumerable<SearchProductResponse> ProductsToResponses(List<Product> products)
        {
            var productResponses = products.Select(p => new SearchProductResponse
            {
                ProductID = p.ProductID,
                ProductName = p.ProductName,
                SalePrice = (int)p.UnitPrice,
                Quantity = p.ProductHolding == null ?
                    0 : (int)p.ProductHolding.Quantity
            });
            return productResponses;
        }

        public void RemoveInclude(int id)
        {
            _service.DeleteInclude(id);
            UowCommit();

        }

        public Validation Update(int id, int quantity)
        {
            _validation = _service.Update(id, quantity);
            UowCommit();
            return _validation;
        }
    }
}
