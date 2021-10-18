using ECommerce.Application.Interfaces;
using ECommerce.Domain.Interfaces;
using ECommerce.Service.Interfaces;
using System;
using System.Collections.Generic;

namespace ECommerce.Application
{
    public class BaseApplication<T> : IBaseApplication<T> where T : class, IBaseEntity
    {
        private readonly IBaseService<T> _service;
        public BaseApplication(IBaseService<T> service) => _service = service;

        public virtual void AddOrUpdate(T obj)
        {
            try
            {
                if (obj.Id == 0)
                    _service.Add(obj);
                else
                    _service.Update(obj);
            }
            catch (Exception ex)
            {
                throw new Exception(!string.IsNullOrEmpty(ex.Message) ? ex.Message : ex.InnerException?.Message);
            }
        }

        public virtual IList<T> GetAll(string query) => _service.GetAll(query);

        public virtual T GetById(long id) => _service.GetById(id);

        public virtual void Remove(T obj)
        {
            _service.Remove(obj);
        }
    }
}