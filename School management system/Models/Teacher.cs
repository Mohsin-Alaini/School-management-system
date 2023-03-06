using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace School_management_system.Models
{
    public class Teacher
    {
        [Key]
        public int TeacherId { get; set; }
        [Required]
        [StringLength(50)]
        public string TeacherFName { get; set; } 
        [Required]
        [StringLength(50)]
        public string TeacherLName { get; set; }
        public float TeacherSalary { get; set; }
        public string TeacherEmail { get; set; }

        [Required]
        public string TeacherPhoneNumber { get; set; }
        [Required]
        public DateTime TeacherBirth_Day { get; set; } = DateTime.Now;

        public string TeacherGender { get; set; }

        // One
        public int SubjectId { get; set; }
        [ForeignKey("SubjectId")]
        public virtual Subject? Subject { get; set; }

        // Many 
        public IEnumerable<Class> Class { get; set; }


    }
}
