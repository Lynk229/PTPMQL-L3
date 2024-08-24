using System.ComponentModel.DataAnnotations;

namespace DemoMvc.Models
{
    public class StudentController
    {
        [Key]
        public String? StudentID { get; set; }
        public string? Fullname { get; set; }
        public string? STT { get; set; }
    }
}
 // Update Homework (20/08)
 //Le Khanh Ly - 2021050423