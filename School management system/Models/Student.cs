using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace School_management_system.Models
{
    public class Student
    { 


        [Key]
        public int StudentId { get; set; } 
        [Required]
        [StringLength(50)]
        public string StudentFName { get; set; }
        [Required]
        [StringLength(50)]
        public string StudentLName { get; set; }
        public string StudentEmail { get; set; }

        [Required]
        public string StudentPhoneNumber { get; set; }
        [Required]
        public DateTime StudentBirth_Day { get; set; }= DateTime.Now;

        public string StudentGender { get; set; }
        
        // Many to many 
        public virtual ICollection<Result> Results { get; set; }
        // Many
        public virtual IEnumerable<Class> Classes { get; set; }








    }
}
