using System.ComponentModel.DataAnnotations;

namespace DemoMvc.Models
{
    public class Phanphoi
    {
        [Key]
        public int DailyID { get; set;}
        public string? Tendaily { get; set;}
        public int Diachi { get; set;}
        
    }
}