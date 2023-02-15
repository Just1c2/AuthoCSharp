using System.ComponentModel.DataAnnotations;

namespace AuthoEx.Models
{
    public class Exam
    {
        [Key]
        public long ExamId { get; set; }

        [Required]
        [Range(0, 100, ErrorMessage = "Score must be between 0 and 100")]
        public int Score { get; set; }

        public long StudentId { get; set; }
        public Student? Student { get; set; }

        public int SubjectId { get; set; }
        public Subject? Subject { get; set; }
    }
}
