using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using DemoMvc.Models;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace DemoMvc.Controllers;
public class PhanphoiController : Controller

{private readonly ILogger<PhanphoiController> _logger;

    public PhanphoiController(ILogger<PhanphoiController> logger)
    {
        _logger = logger;
    }
        public IActionResult Index()
        {
            return View();
        }

    [HttpPost]
    public IActionResult Index(string DailyID, string Tendaily, string Diachi )
    {
        string strOutput = "Xin chào" + DailyID + "-" + Tendaily + "-" + Diachi;
        ViewBag.PP = strOutput;
        return View();
    }
    public IActionResult Privacy()
    {
        return View();
    }

      
    }