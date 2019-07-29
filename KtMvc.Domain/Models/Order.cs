namespace KtMvc.Domain.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Order
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Order()
        {
            OrderLines = new HashSet<OrderLine>();
            ProductTransactions = new HashSet<ProductTransaction>();
        }

        public int OrderID { get; set; }

        public int CustomerID { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime OrderDate { get; set; }

        [StringLength(10)]
        public string PostalCode { get; set; }

        [StringLength(50)]
        public string City { get; set; }

        [StringLength(500)]
        public string AddressLine { get; set; }

        [StringLength(50)]
        public string Dist { get; set; }

        [StringLength(50)]
        public string OrderNO { get; set; }

        public virtual Customer Customer { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OrderLine> OrderLines { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ProductTransaction> ProductTransactions { get; set; }
    }
}
