﻿using System.Collections.Generic;

namespace ECommerce.Data.Repositories.Interfaces
{
    public interface IBaseRepository<T> where T : class
    {
        T GetById(long id);
        IList<T> GetAll(string query);
        void Add(T obj);
        void Update(T obj);
        void Remove(T obj);
    }
}