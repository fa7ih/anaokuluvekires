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
    public class EfStudentDal : GenericRepository<Student>, IStudentDal
    {
        Context context = new Context();

        public List<Student> GetlistWithStudentByAccepted(int id)
        {
            return context.Students.Where(y => y.Status == "Onaylandı" && y.AppUserId == id).ToList();
        }

        public List<Student> GetlistWithStudentByWaitDisapproved(int id)
        {
            return context.Students.Where(y => y.Status == "Onaylanmadı" && y.AppUserId == id).ToList();
        }
    }
}
