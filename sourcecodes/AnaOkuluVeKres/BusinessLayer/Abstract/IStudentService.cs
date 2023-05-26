using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IStudentService:IGenericService<Students2>
    {
        List<Students2> GetListApprovalStudent(int id);
        List<Students2> GetlistWithStudentByAccepted(int id);
        List<Students2> GetlistWithStudentByWaitDisapproved(int id);
    }
}
