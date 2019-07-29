using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KtMvc.Domain.Models;

namespace KtMvc.Domain.BizValidation
{
    class ProductValidateSpec : IValidateSpec<Product>
    {
        private Validation validation = new Validation();
        public Validation Validate(Product product)
        {
            if (product.UnitPrice < 0)
            {
                string errorMessagae = "商品單價必須大於 0 ";
                validation.AddRule(new ValidationRule(errorMessagae));
            }

            if (product.ProductName.Length < 2)
            {
                string errorMessagae = "商品名稱必須至少兩個字元";
                validation.AddRule(new ValidationRule(errorMessagae));
            }

            return validation;
        }
    }
}
