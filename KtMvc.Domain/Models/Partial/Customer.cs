using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KtMvc.Domain.BizValidation;

namespace KtMvc.Domain.Models
{
    public partial class Customer : EntityAggregateRootBase<int>
    {
        public override Validation Validate()
        {
            var validateSpec = new CustomerValidateSpec();
            Validation validation = validateSpec.Validate(this);
            return validation;
        }
    }
}
