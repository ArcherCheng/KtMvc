namespace KtMvc.Domain.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ProductTransaction
    {
        public int ProductTransactionID { get; set; }

        public int ProductID { get; set; }

        public int OrderID { get; set; }

        public int Quantity { get; set; }

        public DateTime TransactionDate { get; set; }

        public virtual Order Order { get; set; }

        public virtual Product Product { get; set; }
    }
}
