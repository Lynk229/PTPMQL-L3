using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace DemoMvc.Models
{
    [Table ("Person")]
    public class Person
    {
        [Key]
        public int CCCD {get; set;}
        public string? HoTen {get; set;}
        public string? QueQuan {get; set;}
    }
}