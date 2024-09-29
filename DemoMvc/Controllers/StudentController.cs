using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using DemoMvc.Models;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace DemoMvc.Controllers;
public class StudentController : Controller

{private readonly ILogger<StudentController> _logger;

    public StudentController(ILogger<StudentController> logger)
    {
        _logger = logger;
    }
        public IActionResult Index()
        {
            return View();
        }

    [HttpPost]
    public IActionResult Index(string StudentID, string Fullname, string Diachi )
    {
        string strOutput = "Xin chào" + StudentID + "-" + Fullname + "-" + Diachi;
        ViewBag.TB = strOutput;
        return View();
    }
    public IActionResult Privacy()
    {
        return View();
    }

      
    }
