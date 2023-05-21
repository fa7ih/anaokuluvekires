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
    public class StudentManager : IStudentService
    {
        IStudentDal _studentDal;

        public StudentManager(IStudentDal studentDal)
        {
            _studentDal = studentDal;
        }

        public List<Student> GetList()
        {
            return _studentDal.GetList();
        }

        public List<Student> GetListApprovalStudent(int id)
        {
            return _studentDal.GetListByFilter(x=>x.AppUser.Id == id && x.Status == "Onay Bekliyor");
        }

        public List<Student> GetlistWithStudentByAccepted(int id)
        {
            return _studentDal.GetlistWithStudentByAccepted(id);
        }

        public List<Student> GetlistWithStudentByWaitDisapproved(int id)
        {
            return _studentDal.GetlistWithStudentByWaitDisapproved(id);
        }

        public void TAdd(Student t)
        {
            _studentDal.Insert(t);
        }

        public void TDelete(Student t)
        {
            _studentDal.Delete(t);
        }

        public Student TGetById(int id)
        {
            return _studentDal.GetById(id);
        }

        public void TUpdate(Student t)
        {
            _studentDal.Update(t);
        }
    }
}
