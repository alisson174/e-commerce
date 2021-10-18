using ECommerce.Data.Repositories.Interfaces;
using ECommerce.Domain.Interfaces;
using ECommerce.Service.Interfaces;
using System.Collections.Generic;

namespace ECommerce.Service
{
    public class BaseService<T> : IBaseService<T> where T : class, IBaseEntity
    {
        private readonly IBaseRepository<T> _repository;
        public BaseService(IBaseRepository<T> repository) => _repository = repository;

        public virtual void Add(T obj) => _repository.Add(obj);

        public virtual IList<T> GetAll(string query) => _repository.GetAll(query);

        public virtual T GetById(long id) => _repository.GetById(id);

        public virtual void Remove(T obj) => _repository.Remove(obj);

        public virtual void Update(T obj) => _repository.Update(obj);
    }
}