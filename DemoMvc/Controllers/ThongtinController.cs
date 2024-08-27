
using Microsoft.AspNetCore.Mvc;
using DemoMVC.Models;


namespace DemoMvc.Controllers;
public class ThongtinController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
    [HttpPost]
    public IActionResult Index(Thongtin ps)
    {
        string  strResult = "Xin chào" + ps.Fullname + "-" + ps.Tuoi + "-" + ps.Adderss;
        ViewBag.tbmn = strResult;
        return View();
    }
}

//Lê Khánh Ly - 2021050423
//Bài thực hành trên lớp ngày 27/08