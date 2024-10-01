using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DemoMvc.Models
{
    [Table("Employee")]
    public class Employee : Person
    {
        [Key]
        public int EmployeeID {get; set;}
        public string? HoTen {get; set;}
        public string? QueQuan {get; set;}
    }
}