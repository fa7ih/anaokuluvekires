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
    public class ParentManager : IParentService
    {
        IParentDal _parentDal;

        public ParentManager(IParentDal parentDal)
        {
            _parentDal = parentDal;
        }

        public List<Parent> GetList()
        {
            return _parentDal.GetList();
        }

        public void TAdd(Parent t)
        {
            _parentDal.Insert(t);
        }

        public void TDelete(Parent t)
        {
            _parentDal.Delete(t);
        }

        public Parent TGetById(int id)
        {
            throw new NotImplementedException();
        }

        public void TUpdate(Parent t)
        {
            _parentDal.Update(t);
        }
    }
}
