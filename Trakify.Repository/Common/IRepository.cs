using System;
using System.Collections.Generic;
using System.Text;
using Trakify.Domain.Common;
using Trakify.Domain.Entities;

namespace Trakify.Repository.Common
{
    public interface IRepository<T> where T : BaseEntity
    {
        IEnumerable<T> GetAll();
        T Get(long id);
        int Insert(T entity);
        int Update(T entity);
        int Delete(T entity);
        void Remove(T entity);
        int SaveChanges();
       
    }
}
