using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KtMvc.Domain.Models;

namespace KtMvc.Infrastructure.Context
{
    public class CustomerConfiguration : EntityTypeConfiguration<Customer>
    {
        public CustomerConfiguration()
        {
            //this.ToTable("Customers");
            //this.HasKey(x => x.EngtityId)
            //    .Property(x => x.EngtityId)
            //    .HasColumnName("CustomerID");

            //this.Property(x => x.Address.PostalCode)
            //    .HasColumnName("PostalCode");
            //this.Property(x => x.Address.City)
            //    .HasColumnName("City");
            //this.Property(x => x.Address.AddressLine)
            //    .HasColumnName("AddressLine");
            //this.Property(x => x.Address.Dist)
            //    .HasColumnName("Dist");
        }
    }
}
