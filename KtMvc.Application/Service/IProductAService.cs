using KtMvc.Application.Dtos;
using KtMvc.Domain.BizValidation;
using KtMvc.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KtMvc.Application.Service
{
    public interface IProductAService:IApplicationService<Product>
    {
        IEnumerable<SearchProductResponse> GetProducts(SearchProductRequest searchProductRequest);
        Validation CreateInclude(Product product);
        Validation Update(int id, int quantity);
        void RemoveInclude(int id);

    }
}
