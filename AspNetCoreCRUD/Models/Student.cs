using System.ComponentModel.DataAnnotations;

namespace StudentappCRUD.Models
{
    public class Student
    {
        [Key]
        [Display(Name="Student ID")]
        public int StudnetId { get; set; }

        [Required]
        [Display(Name="Student Name")]
        public string Name { get; set; }
        public string Email { get; set; }
        public string Course { get; set; }

        [Display(Name="Enrollment Date")]
        public DateTime EnrollmentDate { get; set; }
    }
}
