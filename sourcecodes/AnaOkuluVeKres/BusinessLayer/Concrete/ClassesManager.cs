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

        public List<Classes> GetList()
        {
            return _classesDal.GetList();
        }

        public void TAdd(Classes t)
        {
            _classesDal.Insert(t);
        }

        public void TDelete(Classes t)
        {
            _classesDal.Delete(t);
        }

        public Classes TGetById(int id)
        {
            return _classesDal.GetById(id);
        }

        public void TUpdate(Classes t)
        {
            _classesDal.Update(t);
        }
    }
}
