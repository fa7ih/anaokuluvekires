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

        public List<Students2> GetList()
        {
            return _studentDal.GetList();
        }

        public List<Students2> GetListApprovalStudent(int id)
        {
            return _studentDal.GetListByFilter(x=>x.AppUser.Id == id && x.Status == "Onay Bekliyor");
        }

        public List<Students2> GetlistWithStudentByAccepted(int id)
        {
            return _studentDal.GetlistWithStudentByAccepted(id);
        }

        public List<Students2> GetlistWithStudentByWaitDisapproved(int id)
        {
            return _studentDal.GetlistWithStudentByWaitDisapproved(id);
        }

        public void TAdd(Students2 t)
        {
            _studentDal.Insert(t);
        }

        public void TDelete(Students2 t)
        {
            _studentDal.Delete(t);
        }

        public Students2 TGetById(int id)
        {
            return _studentDal.GetById(id);
        }

        public void TUpdate(Students2 t)
        {
            _studentDal.Update(t);
        }
    }
}
