using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace IDAO
{
    public interface IDAO<T> where T : class
    {
        int Add(T t);
        int Update(T t);
        int Delete(T t);
        List<T> Select();
        List<T> SelectBy(Expression<Func<T, bool>> where);
        List<T> FenYe<K>(Expression<Func<T, K>> order, Expression<Func<T, bool>> where, int currentPage, int PageSize, out int rows);
    }
}
