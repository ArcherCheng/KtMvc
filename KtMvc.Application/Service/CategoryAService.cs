using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KtMvc.Domain.Models;
using KtMvc.Domain.Repository;
using KtMvc.Domain.Service;

namespace KtMvc.Application.Service
{
    public class CategoryAService : ApplicationService<Category, ICategoryRepository, ICategoryService>,ICategoryAService
    {
        public CategoryAService(ICategoryService service, IUnitOfWork unitOfWork) : base(service, unitOfWork)
        {
        }

        public IEnumerable<Category> GetCategories(string name)
        {
            var categories = _service.GetCategories(name);
            if (categories.Count() > 0)
            {
                return categories;
            }
            return null;
        }
    }
}
