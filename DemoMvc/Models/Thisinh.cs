using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DemoMvc.Models
{
    [Table("Thisinh")]
    public class Thisinh{
        [Key]
        public int ThisinhID { get; set; }
        public string? Fullname { get; set; }

}
}