using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DemoMVC.Models
{
    public class Daily
    {
        [Key]
        public string? Fullname { get; set; }
         public string? Tuoi { get; set; }
        public string? Adderss { get; set; }
    }

}