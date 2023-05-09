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
    public class InformationManager : IInformationService
    {
        IInformationDal _ınformationDal;

        public InformationManager(IInformationDal ınformationDal)
        {
            _ınformationDal = ınformationDal;
        }

        public List<Information> GetList()
        {
            return _ınformationDal.GetList();
        }

        public void TAdd(Information t)
        {
            _ınformationDal.Insert(t);
        }

        public void TDelete(Information t)
        {
            _ınformationDal.Delete(t);
        }

        public Information TGetById(int id)
        {
            throw new NotImplementedException();
        }

        public void TUpdate(Information t)
        {
            _ınformationDal.Update(t);
        }
    }
}
