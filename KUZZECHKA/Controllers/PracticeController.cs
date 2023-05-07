using Microsoft.AspNetCore.Mvc;

namespace KUZZECHKA.Controllers
{
    public class PracticeController : Controller
    {
        private readonly ILogger<PracticeController> _logger;

        public PracticeController(ILogger<PracticeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Bank()
        {
            return View();
        }

        public IActionResult Gym()
        {
            return View();
        }

        public IActionResult Hospital()
        {
            return View();
        }

        public IActionResult Rent()
        {
            return View();
        }

        public IActionResult Shop()
        {
            return View();
        }

        public IActionResult Transport()
        {
            return View();
        }

        public IActionResult University() 
        {
            return View();
        }
    }
}
