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
    public class ClassesManager : IClassesService
    {
        IClassesDal _classesDal;

        public ClassesManager(IClassesDal classesDal)
        {
            _classesDal = classesDal;
        }

        public List<StudentClasses> GetList()
        {
            return _classesDal.GetList();
        }

        public void TAdd(StudentClasses t)
        {
            _classesDal.Insert(t);
        }

        public void TDelete(StudentClasses t)
        {
            _classesDal.Delete(t);
        }

        public StudentClasses TGetById(int id)
        {
            return _classesDal.GetById(id);
        }

        public void TUpdate(StudentClasses t)
        {
            _classesDal.Update(t);
        }
    }
}
