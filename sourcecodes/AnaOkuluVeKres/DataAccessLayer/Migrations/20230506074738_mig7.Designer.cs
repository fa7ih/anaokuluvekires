﻿// <auto-generated />
using DataAccessLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DataAccessLayer.Migrations
{
    [DbContext(typeof(Context))]
    [Migration("20230506074738_mig7")]
    partial class mig7
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.13")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("EntityLayer.Concrete.About", b =>
                {
                    b.Property<int>("AboutId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AboutDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AboutImage1")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("AboutStatus")
                        .HasColumnType("bit");

                    b.Property<string>("AboutSubDescription1")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AboutSubDescription2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AboutSubDescription3")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AboutTitle")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("AboutId");

                    b.ToTable("Abouts");
                });

            modelBuilder.Entity("EntityLayer.Concrete.About2", b =>
                {
                    b.Property<int>("About2Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("About2Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("About2Status")
                        .HasColumnType("bit");

                    b.Property<string>("AboutTitle")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("About2Id");

                    b.ToTable("Abouts2");
                });

            modelBuilder.Entity("EntityLayer.Concrete.Contact", b =>
                {
                    b.Property<int>("ContactId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ContactDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ContactDetails")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ContactMail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ContactName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ContactPhone")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Status")
                        .HasColumnType("bit");

                    b.HasKey("ContactId");

                    b.ToTable("Contacts");
                });

            modelBuilder.Entity("EntityLayer.Concrete.Feature", b =>
                {
                    b.Property<int>("FeatureId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("FeatureDescription1")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FeatureDescription2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FeatureDescription3")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FeatureDescription4")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FeatureHeadTitle")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FeatureTitle1")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FeatureTitle2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FeatureTitle3")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FeatureTitle4")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("FeatureId");

                    b.ToTable("Features");
                });

            modelBuilder.Entity("EntityLayer.Concrete.Newsletter", b =>
                {
                    b.Property<int>("NewsletterId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Mail")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("NewsletterId");

                    b.ToTable("Newsletters");
                });

            modelBuilder.Entity("EntityLayer.Concrete.Parent", b =>
                {
                    b.Property<int>("ParentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ParentNameSurname")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ParentPassword")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("ParentStatus")
                        .HasColumnType("bit");

                    b.Property<string>("ParentUserName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ParentId");

                    b.ToTable("Parents");
                });

            modelBuilder.Entity("EntityLayer.Concrete.Student", b =>
                {
                    b.Property<int>("StudentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("StudentBranch")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("StudentClass")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("StudentImageUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("StudentName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("StudentNo")
                        .HasColumnType("int");

                    b.Property<bool>("StudentStatus")
                        .HasColumnType("bit");

                    b.Property<string>("StudentSurName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("StudentId");

                    b.ToTable("Students");
                });

            modelBuilder.Entity("EntityLayer.Concrete.StudentStatus", b =>
                {
                    b.Property<int>("StudentStatusId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("StudentStatusAdaptation")
                        .HasColumnType("int");

                    b.Property<int>("StudentStatusAlphabet")
                        .HasColumnType("int");

                    b.Property<int>("StudentStatusDevelopment")
                        .HasColumnType("int");

                    b.Property<int>("StudentStatusHealth")
                        .HasColumnType("int");

                    b.Property<int>("StudentStatusInClassSituation")
                        .HasColumnType("int");

                    b.Property<int>("StudentStatusMaths")
                        .HasColumnType("int");

                    b.Property<int>("StudentStatusTeachNotes")
                        .HasColumnType("int");

                    b.HasKey("StudentStatusId");

                    b.ToTable("StudentStatuses");
                });

            modelBuilder.Entity("EntityLayer.Concrete.Teacher", b =>
                {
                    b.Property<int>("TeacherId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("TeacherBiography")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TeacherBranch")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TeacherImgUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TeacherNameSurname")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TeacherPassword")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TeacherStatus")
                        .HasColumnType("bit");

                    b.Property<string>("TeacherUserName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("TeacherId");

                    b.ToTable("Teachers");
                });

            modelBuilder.Entity("EntityLayer.Concrete.Testimonial", b =>
                {
                    b.Property<int>("TestimonialId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("TestimonialDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TestimonialImageStatus")
                        .HasColumnType("bit");

                    b.Property<string>("TestimonialImageUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TestimonialNameSurname")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("TestimonialId");

                    b.ToTable("Testimonials");
                });
#pragma warning restore 612, 618
        }
    }
}
