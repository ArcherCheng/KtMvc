namespace KtMvc.Domain.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Product
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Product()
        {
            OrderLines = new HashSet<OrderLine>();
            ProductTransactions = new HashSet<ProductTransaction>();
        }

        public int ProductID { get; set; }

        [Required(ErrorMessage = "商品名稱不可空白")]
        [StringLength(50)]
        public string ProductName { get; set; }

        [Required(ErrorMessage = "商品價格不可空白")]
        public decimal UnitPrice { get; set; }

        public int? CategoryID { get; set; }

        public string Description { get; set; }

        public virtual Category Category { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OrderLine> OrderLines { get; set; }

        public virtual ProductHolding ProductHolding { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ProductTransaction> ProductTransactions { get; set; }
    }
}
