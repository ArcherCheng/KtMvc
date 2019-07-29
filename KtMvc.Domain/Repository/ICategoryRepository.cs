﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KtMvc.Domain.Models;

namespace KtMvc.Domain.Repository
{
    public interface ICategoryRepository: IRepository<Category>, IUnitOfWorkRepository
    {
        IEnumerable<Category> FindByName(string name);
    }
}
