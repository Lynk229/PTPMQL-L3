using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using DemoMvc.Models;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace DemoMvc.Controllers;
public class ThongtinController : Controller

{private readonly ILogger<ThongtinController> _logger;

    public ThongtinController(ILogger<ThongtinController> logger)
    {
        _logger = logger;
    }
        public IActionResult Index()
        {
            return View();
        }

    [HttpPost]
    public IActionResult Index(string MaNV, string TenNV, string Tuoi )
    {
        string strOutput = "Xin chào" + MaNV + "-" + TenNV + "-" + Tuoi;
        ViewBag.TT = strOutput;
        return View();
    }
    public IActionResult Privacy()
    {
        return View();
    }
    }