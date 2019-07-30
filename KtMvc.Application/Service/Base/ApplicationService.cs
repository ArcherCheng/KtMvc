using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KtMvc.Domain.BizValidation;
using KtMvc.Domain.Models;
using KtMvc.Domain.Repository;
using KtMvc.Domain.Service;

namespace KtMvc.Application.Service
{
    public class ApplicationService<TEntity, IEntityRepository, IEntityService> : IApplicationService<TEntity>
        where TEntity : EntityBase<int>
        where IEntityRepository: IRepository<TEntity>
        where IEntityService : IService<TEntity,IEntityRepository>
    {
        protected IUnitOfWork _unitOfWork;
        protected Validation _validation;
        protected IEntityService _service;

        public ApplicationService(IEntityService service, IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
            _service = service;
            _validation = new Validation();
            _unitOfWork.RegisterRepository((IUnitOfWorkRepository)_service.DomainRepository);
        }

        public Validation Create(TEntity entity)
        {
            _validation = _service.Add(entity);
            UowCommit();
            return _validation;
        }

        public TEntity Details(int id)
        {
            var entity = _service.Get(id);
            return entity;
        }

        public IEnumerable<TEntity> ListAll()
        {
            var entities = _service.GetAll();
            return entities;
        }

        public Validation Remove(int id)
        {
            _validation = _service.Delete(id);
            UowCommit();
            return _validation;
        }

        public Validation Update(TEntity entity)
        {
            _validation = _service.Update(entity);
            UowCommit();
            return _validation;
        }

        protected void UowCommit()
        {
            if (!(_validation.GetRules().Count() > 0))
                _unitOfWork.Commit();
        }
    }
}
