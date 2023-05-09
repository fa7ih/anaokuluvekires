using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class StudentStatusManager : IStudentStatusService
    {
        IStudentStatusDal _studentStatusDal;

        public StudentStatusManager(IStudentStatusDal studentStatusDal)
        {
            _studentStatusDal = studentStatusDal;
        }

        public List<StudentStatus> GetList()
        {
            return _studentStatusDal.GetList();
        }

        public void TAdd(StudentStatus t)
        {
            _studentStatusDal.Insert(t);
        }

        public void TDelete(StudentStatus t)
        {
            _studentStatusDal.Delete(t);
        }

        public StudentStatus TGetById(int id)
        {
            throw new NotImplementedException();
        }

        public void TUpdate(StudentStatus t)
        {
            _studentStatusDal.Update(t);
        }
    }
}
