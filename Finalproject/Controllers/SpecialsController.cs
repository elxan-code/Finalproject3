using Finalproject.Data;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Finalproject.Controllers
{
    public class SpecialsController : Controller
    {

        private readonly AppDbContext _context;
        public SpecialsController(AppDbContext context)
        {
            _context = context;

        }
        public IActionResult Index()
        {
            return View(_context.Specials.ToList());
        }
        public IActionResult SpecialDeatails()
        {
            return View();
        }
    }
}
