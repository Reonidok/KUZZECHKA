using System.ComponentModel.DataAnnotations;

namespace KUZZECHKA.Models
{
    public class SurveyResult
    {
        public int Id { get; set; }

        [Required]
        public string UserId { get; set; }

        public string Answer1 { get; set; }
        public string Answer2 { get; set; }

        // Добавьте больше свойств для хранения ответов на вопросы опроса
    }
}
