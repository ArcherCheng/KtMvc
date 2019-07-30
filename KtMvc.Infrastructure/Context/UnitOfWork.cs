using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KtMvc.Domain.Repository;

namespace KtMvc.Infrastructure.Context
{
    public class UnitOfWork : IUnitOfWork, IDisposable
    {
        private KtMvcModel1 db;
    
        public void Commit()
        {
            db.SaveChanges();
        }

        public void Dispose()
        {
            Dispose(true);
        }

        private bool disposedValue = false;
        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if(disposing)
                {
                    db.Dispose();
                }
            }
        }

        public void RegisterRepository(IUnitOfWorkRepository repository)
        {
            repository.context = db;
        }
    }
}
