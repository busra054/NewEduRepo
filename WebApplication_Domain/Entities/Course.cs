﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace WebApplication_Domain.Entities
{
    public class Course
    {
        [Key]
        public int Id { get; set; }

        [DisplayName("Ders Adı")]
        [Required(ErrorMessage = "Ders adı boş geçilemez!")]
        public string Name { get; set; }

        [DisplayName("Ders Açıklaması")]
        public string Description { get; set; }

        public int TeacherId { get; set; }
        public int PackageId { get; set; } // Hangi pakete ait olduğu

        // Relationships
        public User Teacher { get; set; }
        public Package Package { get; set; }
        public ICollection<CourseMaterial> CourseMaterials { get; set; }
        public ICollection<CourseEnrollment> EnrolledStudents { get; set; }

    }
}
