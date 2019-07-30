using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KtMvc.Domain.Models;
using KtMvc.Domain.Repository;

namespace KtMvc.Domain.Service
{
    public class CategoryService : DomainService<Category, ICategoryRepository>, ICategoryService
    {
        public CategoryService(ICategoryRepository repository) : base(repository)
        {
        }

        public IEnumerable<Category> GetCategories(string name)
        {
            IEnumerable<Category> categories;
            if(name == null || name.Length == 0)
            {
                categories = _repository.FindAll();
            }
            else
            {
                categories = _repository.FindByName(name);
            }

            return categories;
        }
          
    }
}
