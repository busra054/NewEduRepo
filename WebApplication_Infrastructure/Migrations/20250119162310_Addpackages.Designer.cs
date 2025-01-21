﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebApplication_Infrastructure.Data;

#nullable disable

namespace WebApplication_Infrastructure.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20250119162310_Addpackages")]
    partial class Addpackages
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("WebApplication_Domain.Entities.Admin", b =>
                {
                    b.Property<int>("AdminId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("AdminId"));

                    b.Property<string>("AdminName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AdminPassword")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("AdminId");

                    b.ToTable("Admins");
                });

            modelBuilder.Entity("WebApplication_Domain.Entities.Appointment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<int>("StudentId")
                        .HasColumnType("int");

                    b.Property<int>("TeacherId")
                        .HasColumnType("int");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("StudentId");

                    b.HasIndex("TeacherId");

                    b.ToTable("Appointments");
                });

            modelBuilder.Entity("WebApplication_Domain.Entities.Branch", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Branches");
                });

            modelBuilder.Entity("WebApplication_Domain.Entities.Course", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PackageId")
                        .HasColumnType("int");

                    b.Property<int>("TeacherId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("PackageId");

                    b.HasIndex("TeacherId");

                    b.ToTable("Course");
                });

            modelBuilder.Entity("WebApplication_Domain.Entities.CourseEnrollment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CourseId")
                        .HasColumnType("int");

                    b.Property<int>("StudentId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CourseId");

                    b.HasIndex("StudentId");

                    b.ToTable("CourseEnrollment");
                });

            modelBuilder.Entity("WebApplication_Domain.Entities.CourseMaterial", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CourseId")
                        .HasColumnType("int");

                    b.Property<string>("FilePath")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("UploadDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("UploadedById")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CourseId");

                    b.HasIndex("UploadedById");

                    b.ToTable("CourseMaterial");
                });

            modelBuilder.Entity("WebApplication_Domain.Entities.Message", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("MessageText")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ReceiverId")
                        .HasColumnType("int");

                    b.Property<int>("SenderId")
                        .HasColumnType("int");

                    b.Property<DateTime>("SentDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("ReceiverId");

                    b.HasIndex("SenderId");

                    b.ToTable("Messages");
                });

            modelBuilder.Entity("WebApplication_Domain.Entities.Package", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int?>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Packages");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "TYT genel tüm dersler eğitimi",
                            Name = "TYT-Eğitimi",
                            Price = 10000.0m
                        },
                        new
                        {
                            Id = 2,
                            Description = "AYT temelden gelişmişe Matematik ,Fizik, Kimya, Biyoloji eğitimi",
                            Name = "AYT-Sayısal-Eğitimi",
                            Price = 12000.0m
                        },
                        new
                        {
                            Id = 3,
                            Description = "AYT temelden gelişmişe Matematik ,Tarih, Coğrafya, Edebiyat eğitimi",
                            Name = "AYT-Eşit ağırlık-Eğitimi",
                            Price = 11000.0m
                        },
                        new
                        {
                            Id = 4,
                            Description = "KPSS temelden gelişmişe full hazırlık paketi",
                            Name = "KPSS Eğitimi",
                            Price = 25000.0m
                        },
                        new
                        {
                            Id = 5,
                            Description = "DGS temelden gelişmişe full hazırlık paketi",
                            Name = "DGS Eğitimi",
                            Price = 15000.0m
                        });
                });

            modelBuilder.Entity("WebApplication_Domain.Entities.Payment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<decimal>("Amount")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("PackageId")
                        .HasColumnType("int");

                    b.Property<DateTime>("PaymentDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("PackageId");

                    b.HasIndex("UserId");

                    b.ToTable("Payments");
                });

            modelBuilder.Entity("WebApplication_Domain.Entities.TeacherBranch", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("BranchId")
                        .HasColumnType("int");

                    b.Property<int>("TeacherId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("BranchId");

                    b.HasIndex("TeacherId");

                    b.ToTable("TeacherBranches");
                });

            modelBuilder.Entity("WebApplication_Domain.Entities.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NormalizedEmail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NormalizedUserName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PasswordHash")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("Role")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("Email")
                        .IsUnique();

                    b.ToTable("Users");
                });

            modelBuilder.Entity("WebApplication_Domain.Entities.Appointment", b =>
                {
                    b.HasOne("WebApplication_Domain.Entities.User", "Student")
                        .WithMany("AppointmentsAsStudent")
                        .HasForeignKey("StudentId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("WebApplication_Domain.Entities.User", "Teacher")
                        .WithMany("AppointmentsAsTeacher")
                        .HasForeignKey("TeacherId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Student");

                    b.Navigation("Teacher");
                });

            modelBuilder.Entity("WebApplication_Domain.Entities.Course", b =>
                {
                    b.HasOne("WebApplication_Domain.Entities.Package", "Package")
                        .WithMany("Courses")
                        .HasForeignKey("PackageId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WebApplication_Domain.Entities.User", "Teacher")
                        .WithMany("CoursesAsTeacher")
                        .HasForeignKey("TeacherId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Package");

                    b.Navigation("Teacher");
                });

            modelBuilder.Entity("WebApplication_Domain.Entities.CourseEnrollment", b =>
                {
                    b.HasOne("WebApplication_Domain.Entities.Course", "Course")
                        .WithMany("EnrolledStudents")
                        .HasForeignKey("CourseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WebApplication_Domain.Entities.User", "Student")
                        .WithMany("EnrolledCourses")
                        .HasForeignKey("StudentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Course");

                    b.Navigation("Student");
                });

            modelBuilder.Entity("WebApplication_Domain.Entities.CourseMaterial", b =>
                {
                    b.HasOne("WebApplication_Domain.Entities.Course", "Course")
                        .WithMany("CourseMaterials")
                        .HasForeignKey("CourseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WebApplication_Domain.Entities.User", "UploadedBy")
                        .WithMany("UploadedMaterials")
                        .HasForeignKey("UploadedById")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Course");

                    b.Navigation("UploadedBy");
                });

            modelBuilder.Entity("WebApplication_Domain.Entities.Message", b =>
                {
                    b.HasOne("WebApplication_Domain.Entities.User", "Receiver")
                        .WithMany("ReceivedMessages")
                        .HasForeignKey("ReceiverId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("WebApplication_Domain.Entities.User", "Sender")
                        .WithMany("SentMessages")
                        .HasForeignKey("SenderId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("Receiver");

                    b.Navigation("Sender");
                });

            modelBuilder.Entity("WebApplication_Domain.Entities.Package", b =>
                {
                    b.HasOne("WebApplication_Domain.Entities.User", null)
                        .WithMany("PurchasedPackages")
                        .HasForeignKey("UserId");
                });

            modelBuilder.Entity("WebApplication_Domain.Entities.Payment", b =>
                {
                    b.HasOne("WebApplication_Domain.Entities.Package", "Package")
                        .WithMany("Payments")
                        .HasForeignKey("PackageId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("WebApplication_Domain.Entities.User", "User")
                        .WithMany("Payments")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("Package");

                    b.Navigation("User");
                });

            modelBuilder.Entity("WebApplication_Domain.Entities.TeacherBranch", b =>
                {
                    b.HasOne("WebApplication_Domain.Entities.Branch", "Branch")
                        .WithMany("TeacherBranches")
                        .HasForeignKey("BranchId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("WebApplication_Domain.Entities.User", "Teacher")
                        .WithMany("TeacherBranches")
                        .HasForeignKey("TeacherId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("Branch");

                    b.Navigation("Teacher");
                });

            modelBuilder.Entity("WebApplication_Domain.Entities.Branch", b =>
                {
                    b.Navigation("TeacherBranches");
                });

            modelBuilder.Entity("WebApplication_Domain.Entities.Course", b =>
                {
                    b.Navigation("CourseMaterials");

                    b.Navigation("EnrolledStudents");
                });

            modelBuilder.Entity("WebApplication_Domain.Entities.Package", b =>
                {
                    b.Navigation("Courses");

                    b.Navigation("Payments");
                });

            modelBuilder.Entity("WebApplication_Domain.Entities.User", b =>
                {
                    b.Navigation("AppointmentsAsStudent");

                    b.Navigation("AppointmentsAsTeacher");

                    b.Navigation("CoursesAsTeacher");

                    b.Navigation("EnrolledCourses");

                    b.Navigation("Payments");

                    b.Navigation("PurchasedPackages");

                    b.Navigation("ReceivedMessages");

                    b.Navigation("SentMessages");

                    b.Navigation("TeacherBranches");

                    b.Navigation("UploadedMaterials");
                });
#pragma warning restore 612, 618
        }
    }
}
