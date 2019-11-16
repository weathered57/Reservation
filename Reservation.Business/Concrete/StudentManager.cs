using Reservation.Business.Abstract;
using Reservation.DataAccess.Abstract;
using Reservation.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reservation.Business.Concrete
{
    public class StudentManager : IStudentService
    {
        private IStudentDal _studentDal;

        public StudentManager(IStudentDal studentDal)
        {
            _studentDal = studentDal;
        }
        public Student Add(Student student)
        {
            return _studentDal.Add(student);
        }

        public List<Student> GetAll()
        {
            return _studentDal.GetList();
        }

        public Student GetById(int schoolNo)
        {
            return _studentDal.Get(x=>x.SchoolNo == schoolNo);
        }

        public Student Update(Student student)
        {
            return _studentDal.Update(student);
        }
    }
}
