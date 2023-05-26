 using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete
{
    public class Context : IdentityDbContext<AppUser, AppRole, int>
    {
        public DbSet<About> Abouts { get; set; }
        public DbSet<About2> Abouts2 { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Contact2> Contacts2 { get; set; }
        public DbSet<Contact3> Contacts3 { get; set; }
        public DbSet<Contact4> Contacts4 { get; set; }
        public DbSet<Parent> Parents { get; set; }
        public DbSet<Students2> Students2 { get; set; }
        public DbSet<StudentStatus> StudentStatuses { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<Feature> Features { get; set; }
        public DbSet<Testimonial> Testimonials { get; set; }
        public DbSet<Information> Informations { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=DESKTOP-BIJ875P;initial catalog=AnaOkuluVeKresDb;Encrypt=False;Integrated Security=True");
        }
    }
}
