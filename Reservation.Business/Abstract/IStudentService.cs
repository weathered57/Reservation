using Reservation.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reservation.Business.Abstract
{
    public interface IStudentService
    {
        List<Student> GetAll();
        Student GetById(int id);
        Student Add(Student student);
        Student Update(Student student);
    }
}
