using System.ComponentModel.DataAnnotations;

namespace DemoMVC.Models
{
    public class Thongtin
    {
        [Key]
        public string? Fullname { get; set; }
        public int Tuoi { get; set; }
        public string? Adderss { get; set; }
    }

}

//Lê Khánh Ly - 2021050423
//Bài thực hành trên lớp ngày 27/08