using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DemoMvc.Models
{
    [Table("Student")]
    public class StudentController
    {
        [Key]
        public String? StudentID { get; set; }
        public string? Fullname { get; set; }
        public string? Address { get; set; }
    }
}