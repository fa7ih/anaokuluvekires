using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    public interface IStudentDal:IGenericDal<Students2>
    {
        List<Students2> GetlistWithStudentByWaitDisapproved(int id);
        List<Students2> GetlistWithStudentByAccepted(int id);
    }
}
