using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KtMvc.Domain.Models;

namespace KtMvc.Domain.BizValidation
{
    class OrderValidateSpec : IValidateSpec<Order>
    {
        Validation validation = new Validation();
        public Validation Validate(Order entity)
        {
            return validation;
        }
    }
}
