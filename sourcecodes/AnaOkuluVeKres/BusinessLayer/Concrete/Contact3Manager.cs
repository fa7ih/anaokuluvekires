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
    public class Contact3Manager : IContact3Service
    {
        IContact3Dal _contact3Dal;

        public Contact3Manager(IContact3Dal contact3Dal)
        {
            _contact3Dal = contact3Dal;
        }

        public List<Contact3> GetList()
        {
            return _contact3Dal.GetList();
        }

        public void TAdd(Contact3 t)
        {
            _contact3Dal.Insert(t);
        }

        public void TDelete(Contact3 t)
        {
            _contact3Dal.Delete(t);
        }

        public Contact3 TGetById(int id)
        {
            return _contact3Dal.GetById(id);
        }

        public void TUpdate(Contact3 t)
        {
            _contact3Dal.Update(t);
        }
    }
}
