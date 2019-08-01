using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KtMvc.Domain.Models;
using System.Data.Entity.ModelConfiguration;

namespace KtMvc.Infrastructure.Context
{
    public class CategoryConfiguration : EntityTypeConfiguration<Category>
    {
        public CategoryConfiguration()
        {
            this.ToTable("Categories");
            this.HasKey(p => p.EntityId).
                Property(p => p.EntityId).
                HasColumnName("CategoryID");
        }
    }
}
