using System.ComponentModel.DataAnnotations;

namespace DemoMvc.Models
{
    public class Student 
    {
        [Key]
        public int StudentID { get; set; }
        public string? Fullname { get; set; }
    }
}