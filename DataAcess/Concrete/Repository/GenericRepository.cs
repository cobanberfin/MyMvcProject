﻿using DataAcess.Abstract;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAcess.Concrete.Repository
{
    public class GenericRepository<T> : IRepository<T> where T : class
    {
        Context c = new Context();
        DbSet<T> _object;
        public GenericRepository()
        {
            _object = c.Set<T>();
        }
        public void Delete(T entity)
        {
            _object.Remove(entity);
            c.SaveChanges();
        }

        public T Get(Expression<Func<T, bool>> Filter)
        {
            return _object.SingleOrDefault(Filter);//sadece bır deger dondur
        }

        public void Insert(T entity)
        {
            var addedEntity = c.Entry(entity);
            addedEntity.State = EntityState.Added;
          //  _object.Add(entity);
            c.SaveChanges();

        }

        public List<T> List()
        {
            return _object.ToList();
        }

        public List<T> List(Expression<Func<T, bool>> filter)
        {
            return _object.Where(filter).ToList();
        }

        public void Update(T entity)
        {
            var updatedEntity = c.Entry(entity);
            updatedEntity.State=EntityState.Modified;

            c.SaveChanges();
        }
    }
}
