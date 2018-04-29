using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace Cms.Data.Infrastructure
{
    public interface IRepository<T> where T : class
    {
        //Marks an entity as new
        T Add(T entity);

        //Marks an entity as modified
        void Update(T entity);

        //Marks an entity to be removed
        T Delete(T entity);

        //Marks an entity to be removed by id
        T Delete(int id);

        //Delete multi records
        void DeleteMulti(Expression<Func<T, bool>> where);

        //Get an entity by int id
        T GetSingleById(int id);

        //Get an entity by condition input
        T GetSingleByCondition(Expression<Func<T, bool>> expression, string[] includes = null);

        //Get all records
        IQueryable<T> GetAll(string[] includes = null);

        //Get multi reocord by condition input
        IQueryable<T> GetMulti(Expression<Func<T, bool>> predicate, string[] includes = null);

        //Get multi record have pagging and filter
       IEnumerable<T> GetMultiPaging(Expression<Func<T, bool>> filter, out int total, int index = 0, int size = 50, string[] includes = null);

        //IQueryable<T> GetMultiPaging(Expression<Func<T, bool>> predicate, out int total, int index = 0, int size = 20, string[] includes = null)

        //Get number records
        int Count(Expression<Func<T, bool>> where);

        //Check entity was container
        bool CheckContains(Expression<Func<T, bool>> predicate);
    }
}