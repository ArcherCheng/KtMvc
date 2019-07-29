namespace KtMvc.Domain.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ProductHolding
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ProductHoldingID { get; set; }

        public int? Quantity { get; set; }

        public int? ReorderLevel { get; set; }

        public virtual Product Product { get; set; }
    }
}
