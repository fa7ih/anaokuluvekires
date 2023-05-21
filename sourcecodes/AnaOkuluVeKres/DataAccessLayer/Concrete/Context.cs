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
        public DbSet<Newsletter> Newsletters { get; set; }
        public DbSet<Parent> Parents { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<StudentStatus> StudentStatuses { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<Feature> Features { get; set; }
        public DbSet<Testimonial> Testimonials { get; set; }
        public DbSet<Information> Informations { get; set; }
        public DbSet<AppRoleTeacher> AppRoleTeachers { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=DESKTOP-BIJ875P;initial catalog=AnaOkuluVeKresDb;Encrypt=False;Integrated Security=True");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AppRoleTeacher>()
                .HasKey(at => new { at.TeacherId, at.AppRoleId });

            modelBuilder.Entity<AppRoleTeacher>()
                .HasOne(at => at.Teacher)
                .WithMany(t => t.AppRoleTeachers)
                .HasForeignKey(at => at.TeacherId);

            modelBuilder.Entity<AppRoleTeacher>()
                .HasOne(at => at.AppRole)
                .WithMany(ar => ar.AppRoleTeachers)
                .HasForeignKey(at => at.AppRoleId);


            base.OnModelCreating(modelBuilder);
        }

    }
}
