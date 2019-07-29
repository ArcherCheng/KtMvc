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
    public class DomainService<T, TRespository> : IService<T, TRespository>
        where T : EntityBase<T>
        where TRespository : IRepository<T>
    {
        protected TRespository _repository ;
        public DomainService(TRespository repository)
        {
            _repository = repository;
        }

        public TRespository DomainRepository
        {
            get { return _repository; }
        }

        public Validation Add(T entity)
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

        private Validation ValidateExistingEntry(T entity)
        {
            Validation validation = new Validation();
            if(entity == null)
            {
                validation.AddRule(new ValidationRule(""));
            }
            return validation;
        }

        public T Get(int id)
        {
            T entity = _repository.FindById(id);
            return entity;
        }

        public IEnumerable<T> GetAll()
        {
            var list = _repository.FindAll();
            return list;
        }

        public Validation Update(T entity)
        {
            var validation = entity.Validate();
            if (!(validation.GetRules().Count() > 0))
                _repository.Update(entity);

            return validation;

        }
    }
}
