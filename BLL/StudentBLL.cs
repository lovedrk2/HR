using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IBLL;
using Model;
using IDAO;
using DAO;
using IOC;
using System.Linq.Expressions;

namespace BLL
{
    public class StudentBLL : IStudentBLL<StudentModel>
    {
        IStudentDAO<StudentModel> ist = iocCreate.CreateStudentDAO();
        public int Add(StudentModel t)
        {
            return ist.Add(t);
        }

        public int Delete(StudentModel t)
        {
            return ist.Delete(t);
        }

        public List<StudentModel> FenYe<K>(Expression<Func<StudentModel, K>> order, Expression<Func<StudentModel, bool>> where, int currentPage, int PageSize, out int rows)
        {
            throw new NotImplementedException();
        }

        public List<StudentModel> Select()
        {
            return ist.Select();
        }

        public List<StudentModel> SelectBy(Expression<Func<StudentModel, bool>> where)
        {
            throw new NotImplementedException();
        }

        public int Update(StudentModel t)
        {
            return ist.Update(t);
        }
    }
}
