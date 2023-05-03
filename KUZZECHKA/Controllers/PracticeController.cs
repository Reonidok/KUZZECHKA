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
    }
}
