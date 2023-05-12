using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    public interface IStudentDal:IGenericDal<Student>
    {
        List<Student> GetlistWithStudentByWaitDisapproved(int id);
        List<Student> GetlistWithStudentByAccepted(int id);
    }
}
