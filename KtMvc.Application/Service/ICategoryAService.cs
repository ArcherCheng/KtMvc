using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KtMvc.Domain.Models;

namespace KtMvc.Application.Service
{
    public interface ICategoryAService:IApplicationService<Category>
    {
        IEnumerable<Category> GetCategories(string name);
    }
}
