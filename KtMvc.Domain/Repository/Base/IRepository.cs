﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KtMvc.Domain.Repository
{
    public interface IRepository<TEntity>
    {
        TEntity FindById(int id);
        IEnumerable<TEntity> FindAll();
        void Add(TEntity entity);
        void Update(TEntity entity);
        void Delete(TEntity entity);
    }
}
