using System.ComponentModel.DataAnnotations;

namespace AuthoEx.Models
{
    public class Student
    {
        public long StudentId { get; set; }

        [Required]
        [StringLength(150, MinimumLength = 8)]
        public string? Name { get; set; }

        [Required]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:MM/dd/yyyy}")]
        public DateTime DateOfBirth { get; set; }

        [Required]
        [EmailAddress]
        public string? Email { get; set; }

        [Required]
        public string? Address { get; set; }

        public virtual List<Exam>? Exams { get; set; }
    }
}
