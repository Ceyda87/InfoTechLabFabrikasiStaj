using InfoTechLabProjeFabrikasi.Data;
using InfoTechLabProjeFabrikasi.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace InfoTechLabProjeFabrikasi.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly InfoTechLabContext _db;

        public HomeController(ILogger<HomeController> logger, InfoTechLabContext db)
        {
            _logger = logger;
            _db = db;
        }

        public IActionResult Index()
        { 
            var home = new HomePageModel
            {
                ExpertCount= _db.Experts.Count(),
                CatogoryCount= _db.Categories.Count(),

            };
            return View(home);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}