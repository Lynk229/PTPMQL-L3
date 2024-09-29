using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace DemoMvc.Models
{
    [Table("Employe")]
    public class Employe
    {
        [Key]
        public int EmployeID { get; set;}
        public string? Fullname { get; set;}
        public string? Diachi { get; set;}
    }
}