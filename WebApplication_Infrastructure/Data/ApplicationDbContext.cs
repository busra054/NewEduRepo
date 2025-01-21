using WebApplication_Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

namespace WebApplication_Infrastructure.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Server=localhost,1433;Database=EducationDB2;User=SA;Password=reallyStrongPwd123;TrustServerCertificate=True");
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Branch> Branches { get; set; }
        public DbSet<TeacherBranch> TeacherBranches { get; set; }
        public DbSet<Appointment> Appointments { get; set; }
        public DbSet<Package> Packages { get; set; }
        public DbSet<Payment> Payments { get; set; }
        public DbSet<Message> Messages { get; set; }
        public DbSet<Admin> Admins { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>()
                .HasKey(u => u.Id);

            modelBuilder.Entity<User>()
                .HasIndex(u => u.Email)
                .IsUnique();

            modelBuilder.Entity<Branch>()
                .HasKey(b => b.Id);

            modelBuilder.Entity<TeacherBranch>()
                .HasKey(tb => tb.Id);

            modelBuilder.Entity<TeacherBranch>()
                .HasOne(tb => tb.Teacher)
                .WithMany(t => t.TeacherBranches)
                .HasForeignKey(tb => tb.TeacherId)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<TeacherBranch>()
                .HasOne(tb => tb.Branch)
                .WithMany(b => b.TeacherBranches)
                .HasForeignKey(tb => tb.BranchId)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<Appointment>()
                .HasKey(a => a.Id);

            modelBuilder.Entity<Appointment>()
                .HasOne(a => a.Student)
                .WithMany(u => u.AppointmentsAsStudent)
                .HasForeignKey(a => a.StudentId)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<Appointment>()
                .HasOne(a => a.Teacher)
                .WithMany(u => u.AppointmentsAsTeacher)
                .HasForeignKey(a => a.TeacherId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<Package>()
                .HasKey(p => p.Id);

            modelBuilder.Entity<Payment>()
                .HasKey(p => p.Id);

            modelBuilder.Entity<Payment>()
                .HasOne<User>(p => p.User)
                .WithMany(u => u.Payments)
                .HasForeignKey(p => p.UserId)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<Payment>()
                .HasOne<Package>(p => p.Package)
                .WithMany(p => p.Payments)
                .HasForeignKey(p => p.PackageId)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<Message>()
                .HasKey(m => m.Id);

            modelBuilder.Entity<Message>()
                .HasOne<User>(m => m.Sender)
                .WithMany(u => u.SentMessages)
                .HasForeignKey(m => m.SenderId)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<Message>()
                .HasOne<User>(m => m.Receiver)
                .WithMany(u => u.ReceivedMessages)
                .HasForeignKey(m => m.ReceiverId)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<Package>().HasData(
               new Package
               {
                   Id = 1,
                   Name = "TYT-Eğitimi Full Paket",
                   Description = "TYT genel tüm dersler temelden gelişmişe adım adım Eğitim",
                   Price = 14000.0m,
               },
new Package
{
    Id = 2,
    Name = "AYT-Sayısal Eğitimi Full Paket",
    Description = "AYT temelden gelişmişe Matematik ,Fizik, Kimya, Biyoloji Dersleri Eğitimi",
    Price = 18000.0m,
},
new Package
{
    Id = 3,
    Name = "AYT-Eşit Ağırlık Eğitimi",
    Description = "AYT temelden gelişmişe Matematik ,Tarih, Coğrafya, Edebiyat Dersleri eğitimi",
    Price = 14000.0m,
},
new Package
{
    Id = 4,
    Name = "KPSS Kapsamlı Eğitimi ",
    Description = "KPSS temelden gelişmişe full hazırlık paketi dersleri",
    Price = 23000.0m,
},
new Package
{
    Id = 5,
    Name = "DGS Kapsamlı Eğitimi",
    Description = "DGS temelden gelişmişe full hazırlık paketi dersleri",
    Price = 13000.0m,
},
new Package
{
    Id = 6,
    Name = "İngilizce A1-A2 Temel Seviye Eğitim",
    Description = "İngilizce temelden gelişmişe okuma,yazma,konuşma ve dinleme becerileri geliştirme dersleri",
    Price = 15000.0m,
},
new Package
{
    Id = 7,
    Name = "İspanyolca A1-A2 Temel Seviye Eğitim",
    Description = "İspanyolca temelden gelişmişe okuma,yazma,konuşma ve dinleme becerileri geliştirme dersleri",
    Price = 12000.0m,
},
new Package
{
    Id = 8,
    Name = "Korece A1-A2 Temel Seviye Eğitim",
    Description = "Korece temelden gelişmişe okuma,yazma,konuşma ve dinleme becerileri geliştirme dersleri",
    Price = 16000.0m,
},
new Package
{
    Id = 9,
    Name = "Almanca A1-B2 Temelden Orta Düzeye(İntermediate) Seviye Eğitim",
    Description = "Almanca temelden gelişmişe okuma,yazma,konuşma ve dinleme becerileri geliştirme dersleri",
    Price = 17000.0m,
}

                );
        }
        public DbSet<WebApplication_Domain.Entities.Course> Course { get; set; } = default!;

    }
}
