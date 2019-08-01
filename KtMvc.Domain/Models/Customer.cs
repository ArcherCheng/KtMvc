namespace KtMvc.Domain.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Customer
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Customer()
        {
            Orders = new HashSet<Order>();
            // Address = new AddressInfo();
        }

        public int CustomerID { get; set; }

        [StringLength(50)]
        [Required(ErrorMessage = "�Ȥ�W�٤��i�ť�")]
        public string CustomerName { get; set; }

        [StringLength(50)]
        public string PhoneNumber { get; set; }

        [Required(ErrorMessage = "�Ȥ�l�󤣥i�ť�")]
        [StringLength(250)]
        public string Email { get; set; }

        [StringLength(10)]
        public string PostalCode { get; set; }

        [StringLength(50)]
        public string City { get; set; }

        [StringLength(500)]
        public string AddressLine { get; set; }

        [StringLength(50)]
        public string Dist { get; set; }

        // public AddressInfo Address { get; set; }


        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Order> Orders { get; set; }
    }
}
