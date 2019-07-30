using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KtMvc.Domain.Repository;
using KtMvc.Domain.Models;


namespace KtMvc.Infrastructure.Repository
{
    public class CategoryRepository : EntityRepository<Category>, ICategoryRepository
    {
        public IEnumerable<Category> FindByName(string name)
        {
            var categories = _dbSet.Where(x => x.CategoryName.Contains(name));
            return categories;
        }
    }
}
