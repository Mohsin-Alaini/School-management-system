using System.ComponentModel.DataAnnotations;

namespace School_management_system.Models
{
    public class Subject
    {
        [Key]
        public int SubjectId { get; set; }
        public string SubjectName { get; set; }

        public string SubjectDescribtion { get; set; }

        // Many to Manyv
        
        public virtual ICollection<Result> Results { get; set; }

        // Many 
        public IEnumerable<Class> Class { get; set; }
        
        // Many 
        public IEnumerable<Teacher> teachers { get; set; }

    }
}
