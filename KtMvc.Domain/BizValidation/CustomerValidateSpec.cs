using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KtMvc.Domain.Models;

namespace KtMvc.Domain.BizValidation
{
    public class CustomerValidateSpec : IValidateSpec<Customer>
    {
        Validation validation = new Validation();
        public Validation Validate(Customer entity)
        {
            if (entity.CustomerName.Length < 2)
            {
                string errorMessage = "商品名稱必須至少兩個字元";
                validation.AddRule(new ValidationRule(errorMessage));
            }

            return validation;
        }
    }
}
