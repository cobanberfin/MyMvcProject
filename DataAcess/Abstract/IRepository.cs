using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace DataAcess.Abstract
{
    public interface IRepository<T> where T : class
    {
        List<T> List();

        void Delete(T entity);
        void Update(T entity);
        void Insert(T entity);

        T Get(Expression<Func<T, bool>> Filter);

        List<T> List(Expression<Func<T, bool>> filter);
    }
}
