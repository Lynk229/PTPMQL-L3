using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using DemoMvc.Models;

namespace DemoMvc.Controllers;

public class StudentController : Controller

{
private readonly ILogger<StudentController> _logger;

    public StudentController(ILogger<StudentController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }    

    [HttpPost]
    public IActionResult Index(string Fullname, string StudentID, string Address)
    {
        string strOutput = "Xin chào" + Fullname + "-" + StudentID + "-" + Address ;
        ViewBag.HH = strOutput;
        return View();
    }
}
 // Update Homework (20/08)
 //Le Khanh Ly - 2021050423