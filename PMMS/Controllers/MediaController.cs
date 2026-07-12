using Microsoft.AspNetCore.Mvc;
using PMMS.Data;
using PMMS.Models;
using System.Linq;

namespace PMMS.Controllers
{
    public class MediaController : Controller
    {
        private readonly ApplicationDbContext _context;

        // 1. Dependency Injection: ASP.NET automatically hands the controller your database connection
        public MediaController(ApplicationDbContext context)
        {
            _context = context;
        }

        // 2. The Action Method: This runs when someone navigates to /Media/Index
        public IActionResult Index()
        {
            // LINQ in action: "Go to the MediaItems table and get everything as a list"
            var myMedia = _context.MediaItems.ToList();

            // Hand that list of data directly to the HTML View
            return View(myMedia);
        }
    }
}