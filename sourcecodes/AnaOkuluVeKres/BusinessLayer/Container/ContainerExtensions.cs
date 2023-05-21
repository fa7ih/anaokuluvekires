using BusinessLayer.Abstract;
using BusinessLayer.Concrete;
using DataAccessLayer.Abstract;
using DataAccessLayer.EntityFramework;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Container
{
    public static class ContainerExtensions
    {
        public static void ContainerDependencies(this IServiceCollection services)
        {
            services.AddScoped<IAppUserService, AppUserManager>();
            services.AddScoped<IAppUserDal, EfAppUserDal>();
            services.AddScoped<IStudentService, StudentManager>();
            services.AddScoped<IStudentDal, EfStudentDal>();
            //services.AddScoped<IInformationService, InformationManager>();
            //services.AddScoped<IInformationDal, EfInformationDal>();
            //services.AddScoped<ITestimonialService, TestimonialManager>();
            //services.AddScoped<ITestimonialDal, EfTestimonialDal>();
            //services.AddScoped<ITeacherService, TeacherManager>();
            //services.AddScoped<ITeacherDal, EfTeacherDal>();
        }
    }
}
