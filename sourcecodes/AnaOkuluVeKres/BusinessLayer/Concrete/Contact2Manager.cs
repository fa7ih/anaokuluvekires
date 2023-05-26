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
    public class Contact2Manager : IContact2Service
    {
        IContact2Dal _contact2Dal;

        public Contact2Manager(IContact2Dal contact2Dal)
        {
            _contact2Dal = contact2Dal;
        }

        public List<Contact2> GetList()
        {
            return _contact2Dal.GetList();  
        }

        public void TAdd(Contact2 t)
        {
            _contact2Dal.Insert(t);
        }

        public void TDelete(Contact2 t)
        {
            _contact2Dal.Delete(t);
        }

        public Contact2 TGetById(int id)
        {
           return _contact2Dal.GetById(id);
        }

        public void TUpdate(Contact2 t)
        {
            _contact2Dal.Update(t);
        }
    }
}
