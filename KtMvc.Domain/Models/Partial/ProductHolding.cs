using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KtMvc.Domain.BizValidation;

namespace KtMvc.Domain.Models.Partial
{
    public partial class ProductHolding : EntityBase<int>
    {
        public override Validation Validate()
        {
            throw new NotImplementedException();
        }
    }
}
