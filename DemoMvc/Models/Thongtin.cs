using System.ComponentModel.DataAnnotations;

namespace DemoMvc.Models

{
    public class Thongtin
    {
        [Key]
        public int MaNV { get; set;}
        public string? TenNV { get; set;}
        public int Tuoi { get; set;}
        
    }
}