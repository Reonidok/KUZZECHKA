using KUZZECHKA.Data;
using KUZZECHKA.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Localization;
using System.Globalization;
using System.Security.Claims;


namespace KUZZECHKA.Controllers
{
    public class SurveyController : Controller
    {
        private readonly SurveyContext _context;
        private readonly IStringLocalizer<HomeController> _localizer;

        public SurveyController(SurveyContext context, IStringLocalizer<HomeController> localizer)
        {
            _context = context;
            _localizer = localizer;
        }

        public IActionResult Index()
        {

            return View();
        }

        public IActionResult ThankYou() 
        {
            return View();
        }

        public async Task<IActionResult> Submit(SurveyViewModel model)
        {
            // Получите идентификатор текущего пользователя
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);

            // Создайте новый объект SurveyResult с данными из модели
            var SurveyResult = new SurveyResult
            {
                UserId = userId,
                Answer1 = model.Answer1,
                Answer2 = model.Answer2,
                Answer3 = model.Answer3,
                Answer4 = model.Answer4,
                Answer5 = model.Answer5,
                Answer6 = model.Answer6,
                Answer7 = model.Answer7,
                Answer8 = model.Answer8,
                Answer9 = model.Answer9,
                Answer10 = model.Answer10,
                Answer11 = model.Answer11,
                Answer12 = model.Answer12,
                Answer13 = model.Answer13,
                Answer14 = model.Answer14,
                Answer15 = model.Answer15,
                // Добавьте больше ответов по мере необходимости
            };

            // Сохраните результаты опроса в базе данных с помощью Entity Framework Core
            _context.SurveyResults.Add(SurveyResult);
            await _context.SaveChangesAsync();

            TempData["SuccessMessage"] = "Ваш опрос был успешно сохранен!";

            return RedirectToAction("ThankYou");
        }
    }
}
