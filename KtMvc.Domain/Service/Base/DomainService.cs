using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KtMvc.Domain.BizValidation;
using KtMvc.Domain.Models;
using KtMvc.Domain.Repository;

namespace KtMvc.Domain.Service
{
    public class DomainService<TEntity, IEntityRespository> : IService<TEntity, IEntityRespository>
        where TEntity : EntityBase<int>
        where IEntityRespository : IRepository<TEntity>
    {
        protected IEntityRespository _repository ;
        public DomainService(IEntityRespository repository)
        {
            _repository = repository;
        }

        public IEntityRespository DomainRepository
        {
            get { return _repository; }
        }

        public Validation Add(TEntity entity)
        {
            var validation = entity.Validate();
            if (!(validation.GetRules().Count() > 0))
                _repository.Add(entity);

            return validation;
        }

        public Validation Delete(int id)
        {
            var entity = _repository.FindById(id);
            var validation = ValidateExistingEntry(entity);
            if (!(validation.GetRules().Count() > 0))
                _repository.Add(entity);

            return validation;

        }

        protected Validation ValidateExistingEntry(TEntity entity)
        {
            Validation validation = new Validation();
            if(entity == null)
            {
                validation.AddRule(new ValidationRule(""));
            }
            return validation;
        }

        public TEntity Get(int id)
        {
            TEntity entity = _repository.FindById(id);
            return entity;
        }

        public IEnumerable<TEntity> GetAll()
        {
            var list = _repository.FindAll();
            return list;
        }

        public Validation Update(TEntity entity)
        {
            var validation = entity.Validate();
            if (!(validation.GetRules().Count() > 0))
                _repository.Update(entity);

            return validation;

        }
    }
}
