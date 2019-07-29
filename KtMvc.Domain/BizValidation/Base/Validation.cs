using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KtMvc.Domain.BizValidation
{
    public class Validation
    {
        private List<ValidationRule> _validationRules = new List<ValidationRule>();

        public void AddRule(ValidationRule rule)
        {
            _validationRules.Add(rule);
        }

        public IEnumerable<ValidationRule> GetRules()
        {
            return _validationRules;
        }
    }
}
