using System.ComponentModel.DataAnnotations;

namespace WebApplication_Domain.Entities
{
    public class TeacherBranch
    {
        [Key]
        public int Id { get; set; }
        public int TeacherId { get; set; }
        public int BranchId { get; set; }

        // Relationships
        public User Teacher { get; set; }
        public Branch Branch { get; set; }
    }
}
