namespace KtMvc.Infrastructure
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;
    using KtMvc.Domain.Models;

    public partial class KMvcModel1 : DbContext
    {
        public KMvcModel1()
            : base("name=KMvcModel1")
        {
        }

        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<OrderLine> OrderLines { get; set; }
        public virtual DbSet<Order> Orders { get; set; }
        public virtual DbSet<ProductHolding> ProductHoldings { get; set; }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<ProductTransaction> ProductTransactions { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>()
                .HasMany(e => e.Products)
                .WithOptional(e => e.Category)
                .WillCascadeOnDelete();

            modelBuilder.Entity<Product>()
                .HasOptional(e => e.ProductHolding)
                .WithRequired(e => e.Product);

            modelBuilder.Configurations.Add(new CustomerConfiguration);
        }
    }
}
