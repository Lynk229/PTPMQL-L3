using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using DemoMvc.Data;
using DemoMvc.Models;

namespace DemoMvc.Controllers
{
    public class ThisinhController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ThisinhController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Thisinh
        public async Task<IActionResult> Index()
        {
            return View(await _context.Thisinh.ToListAsync());
        }

        // GET: Thisisnh/Create
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ThisinhID,Fullname")] Thisinh ts)
        {
            if (ModelState.IsValid)
            {
                _context.Add(ts);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(ts);
        }
    }
}