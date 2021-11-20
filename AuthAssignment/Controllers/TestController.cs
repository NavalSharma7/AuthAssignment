using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AuthAssignment.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace AuthAssignment.Controllers
{
    public class TestController : Controller
    {

        private readonly ILogger<TestController> _logger;
        private readonly ApplicationDbContext _context;

        public TestController(ApplicationDbContext context)
        {
            _context = context;
        }
        // GET: /<controller>/
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Secret()
        {
            return View();
        }
    }
}
