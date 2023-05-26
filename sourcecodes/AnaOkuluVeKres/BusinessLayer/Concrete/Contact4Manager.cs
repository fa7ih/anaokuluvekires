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
    public class Contact4Manager : IContact4Service
    {
        IContact4Dal _contact4Dal;

        public Contact4Manager(IContact4Dal contact4Dal)
        {
            _contact4Dal = contact4Dal;
        }

        public List<Contact4> GetList()
        {
            return _contact4Dal.GetList();
        }

        public void TAdd(Contact4 t)
        {
            _contact4Dal.Insert(t);
        }

        public void TDelete(Contact4 t)
        {
            _contact4Dal.Delete(t);
        }

        public Contact4 TGetById(int id)
        {
            return _contact4Dal.GetById(id);
        }

        public void TUpdate(Contact4 t)
        {
            _contact4Dal.Update(t);
        }
    }
}
