using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using IDAO;
using Model;
using EF;
using System.Threading.Tasks;
using System.Linq.Expressions;

namespace DAO
{
    public class StudentDAO : DaoBase<Student>, IStudentDAO<StudentModel>
    {
        public int Add(StudentModel t)
        {
            Student st = new Student()
            {
                Id = t.Id,
                Name = t.Name
            };

            return Add(st);
        }

        public int Delete(StudentModel t)
        {
            Student st = new Student()
            {
                Name = t.Name,
                Id = t.Id
            };
            return Delete(st);
        }

        public List<StudentModel> FenYe<K>(Expression<Func<StudentModel, K>> order, Expression<Func<StudentModel, bool>> where, int currentPage, int PageSize, out int rows)
        {
            throw new NotImplementedException();
        }

        public List<StudentModel> SelectBy(Expression<Func<StudentModel, bool>> where)
        {
            throw new NotImplementedException();
        }

        public int Update(StudentModel t)
        {
            Student st = new Student()
            {
                Id = t.Id,
                Name = t.Name
            };
            return Update(st);
        }

        List<StudentModel> IDAO<StudentModel>.Select()
        {
            List<Student> list = Select();
            List<StudentModel> list2 = new List<StudentModel>();
            foreach (Student item in list)
            {
                StudentModel sm = new StudentModel()
                {
                    Id = item.Id,
                    Name = item.Name
                };
                list2.Add(sm);
            }
            return list2;
        }
    }
}
