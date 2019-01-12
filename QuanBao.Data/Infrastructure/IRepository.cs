using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace QuanBao.Data.Infrastructure
{
    public interface IRepository<T> where T : class 
    {
        //marks an entity as new
        void Add(T entity);

        //marks an entity as modified
        void Update(T entity);

        //marks an entity as Removed
        void Delete(T entity);

        //marks an entity as records
        void DeleteMulti(Expression<Func<T, bool>> where);

        //get an entity by int id
        T GetSingleById(int id);

        // laay co dk
        T GetSingleByCondition(Expression<Func<T, bool>> expression, string[] includes = null);

       
        IQueryable<T> GetAll(string[] includes = null);

        //lay nhieu
        IQueryable<T> GetMulti(Expression<Func<T, bool>> predicate, string[] incluses = null);

        //lay phan trang
        IQueryable<T> GetMultiPaging(Expression<Func<T, bool>> filter, out int total, int index = 0, int size = 50, string[] incluses = null);

        int Count(Expression<Func<T, bool>> where);
        bool CheckContains(Expression<Func<T,bool>> predicate);
    }
}
