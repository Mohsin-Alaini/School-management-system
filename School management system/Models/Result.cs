using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace School_management_system.Models
{
    public class Result
    {
        public string StudentFname { get; set; }
        public string SubjectName { get; set; }
        public float Mark { get; set; }


        [Key]
        [Column(Order =1)]
        public int SubjectId { get; set; }
        [Key]
        [Column(Order =2)]
        public string StudentId { get; set; }

        public virtual Student Student { get; set; }
        public virtual Subject Subject { get; set; }
    }
}
