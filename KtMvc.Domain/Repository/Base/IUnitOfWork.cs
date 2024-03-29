﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace KtMvc.Domain.Repository
{
    public interface IUnitOfWork
    {
        void RegisterRepository(IUnitOfWorkRepository repository);
        void Commit();
    }
}
