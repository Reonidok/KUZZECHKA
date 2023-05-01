using KUZZECHKA.Data;
using KUZZECHKA.Models;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace KUZZECHKA.Controllers
{
    public class SurveyController : Controller
    {
        private readonly SurveyContext _context;

        public SurveyController(SurveyContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Submit(SurveyViewModel model)
        {
            // Получите идентификатор текущего пользователя
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);

            // Создайте новый объект SurveyResult с данными из модели
            var SurveyResult = new SurveyResult
            {
                UserId = userId,
                Answer1 = model.Answer1,
                Answer2 = model.Answer2
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
