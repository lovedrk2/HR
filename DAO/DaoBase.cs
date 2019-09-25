using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EF;
using System.Threading.Tasks;
using System.Linq.Expressions;

namespace DAO
{
    public class DaoBase<T> where T : class
    {
        MyDbContext db = new MyDbContext();
        public int Add(T t)
        {

            db.Set<T>().Add(t);
            return db.SaveChanges();
        }

        public int Update(T t)
        {
            db.Set<T>().Attach(t);
            db.Entry<T>(t).State = System.Data.Entity.EntityState.Modified;
            return db.SaveChanges();
        }

        public int Delete(T t)
        {
            db.Set<T>().Attach(t);
            db.Entry<T>(t).State = System.Data.Entity.EntityState.Deleted;
            return db.SaveChanges();

        }

        public List<T> Select()
        {

            return db.Set<T>()
                   .AsNoTracking()
                   .Select(e => e)
                   .ToList();
        }

        public List<T> SelectBy(Expression<Func<T, bool>> where)
        {
            return db.Set<T>()
                .AsNoTracking()
                .Where(where)
                .Select(e => e)
                .ToList();
        }

        public List<T> FenYe<K>(Expression<Func<T, K>> order, Expression<Func<T, bool>> where, int currentPage, int PageSize, out int rows)
        {

            var result4 = db.Set<T>()
                .AsNoTracking()
                .OrderBy(order);
            rows = result4.Count();//总行数
            var data = result4.Where(where)
                 .Skip((currentPage - 1) * PageSize)//忽略多少条数
                 .Take(PageSize)//取多少条数
                 .ToList();
            return data;
        }
    }
}
