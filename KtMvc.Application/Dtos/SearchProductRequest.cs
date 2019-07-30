using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KtMvc.Application.Dtos
{
    public class SearchProductRequest
    {
        public int SearchID { get; set; }
        public string SearchName { get; set; }

    }

    public class SearchProductResponse
    {
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public int SalePrice { get; set; }
        public int Quantity { get; set; }

        //Search PH
        public int ReorderLevel { get; set; }
    }

    class SearchPHRequest
    {
        public int SearchID { get; set; }
        public string SearchName { get; set; }
        public int PHLevel { get; set; }
    }
}
