using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using Trakify.Domain;
using Trakify.Domain.Common;

namespace Trakify.Repository.Common
{
    public class Repository<T> : IRepository<T> where T : BaseEntity
    {

        private readonly TrakifyContext context;
        private DbSet<T> entities;
        string errorMessage = string.Empty;

        public Repository(TrakifyContext context)
        {
            this.context = context;
            entities = context.Set<T>();
        }
        public IEnumerable<T> GetAll()
        {
            try
            {
                return entities.Where(x => !x.IsDeleted).ToList();
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public T Get(long id)
        {
            try
            {
                return entities.SingleOrDefault(s => s.Id == id);
            }
            catch (Exception ex)
            {
                return null;
            }
           
        }
        public int Insert(T entity)
        {
            try
            {
                if (entity == null)
                {
                    throw new ArgumentNullException("entity");
                }
                entity.AddedDate = DateTime.Now;
                entities.Add(entity);
                return context.SaveChanges();
            }
            catch (Exception ex)
            {
                return 0;
            }
        }

        public int Update(T entity)
        {
            try
            {
                entity.ModifiedDate = DateTime.UtcNow;
                entities.Attach(entity);
                var entry = context.Entry(entity);
                entry.State = EntityState.Modified;
                return context.SaveChanges();
            }
            catch (Exception ex)
            {
                return 0;
            }
        }

        public int Delete(T entity)
        {
            try
            {
                if (entity == null)
                {
                    throw new ArgumentNullException("entity");
                }
                var data = entities.FirstOrDefault(x => x.Id == entity.Id);
                data.IsDeleted = true;
                return context.SaveChanges();
            }
            catch (Exception ex)
            {
                return 0;
            }
        }
        public void Remove(T entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException("entity");
            }
            entities.Remove(entity);
        }

        public int SaveChanges()
        {
            try
            {
                return context.SaveChanges();
            }
            catch (Exception ex)
            {

                return 0;
            }
           
        }
    }
}
