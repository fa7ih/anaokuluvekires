using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using DataAccessLayer.Repository;
using EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.EntityFramework
{
    public class EfStudentDal : GenericRepository<Students2>, IStudentDal
    {
        Context context = new Context();

        public List<Students2> GetlistWithStudentByAccepted(int id)
        {
            return context.Students2.Where(y => y.Status == "Onaylandı" && y.AppUserId == id).ToList();
        }

        public List<Students2> GetlistWithStudentByWaitDisapproved(int id)
        {
            return context.Students2.Where(y => y.Status == "Onaylanmadı" && y.AppUserId == id).ToList();
        }
    }
}
