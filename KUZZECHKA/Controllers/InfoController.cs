using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Localization;

namespace KUZZECHKA.Controllers
{
    public class InfoController : Controller
    {
        private readonly ILogger<InfoController> _logger;

        public InfoController(ILogger<InfoController> logger) 
        {
            _logger = logger;
        }
        public IActionResult Info()
        {
            return View();
        }
    }
}
