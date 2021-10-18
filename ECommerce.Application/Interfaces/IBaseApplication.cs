using System.Collections.Generic;

namespace ECommerce.Application.Interfaces
{
    public interface IBaseApplication<T> where T : class
    {
        T GetById(long id);
        IList<T> GetAll(string query);
        void AddOrUpdate(T obj);
        void Remove(T obj);
    }
}