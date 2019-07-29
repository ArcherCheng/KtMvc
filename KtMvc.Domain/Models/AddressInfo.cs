using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KtMvc.Domain.Models
{
    [ComplexType]
    public class AddressInfo
    {
        public string PostalCode { get; set; }
        public string City { get; set; }
        public string Dist { get; set; }
        public string AddressLine { get; set; }
    }
}
