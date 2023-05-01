using Microsoft.AspNetCore.Mvc;

namespace KUZZECHKA.Controllers
{
    public class SurveyController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
