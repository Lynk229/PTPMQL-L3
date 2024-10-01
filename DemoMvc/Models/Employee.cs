using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DemoMvc.Models
{
    [Table("Employee")]
    public class Employee : Person
    {
        public int Ma {get; set;}
        public int SDT {get; set;}

    }
}