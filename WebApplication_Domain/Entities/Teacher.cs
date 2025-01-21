using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApplication_Domain.Entities
{
    public class Teacher
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public int UserId { get; set; }
        public User User { get; set; } // User ile bire bir ilişki

        [Required]
        public string Biography { get; set; } // Öğretmenin biyografisi

        [Required]
        public int ExperienceYears { get; set; } // Deneyim yılı

        public string Certifications { get; set; } // Sertifikalar

        // Öğretmene özgü ilişkiler
        public ICollection<TeacherBranch> TeacherBranches { get; set; } = new List<TeacherBranch>();
        public ICollection<Course> Courses { get; set; } = new List<Course>();
    }
}
