using System.ComponentModel.DataAnnotations;

namespace KUZZECHKA.Models
{
    public class SurveyResult
    {
        public int Id { get; set; }

        [Required]
        public string? UserId { get; set; }

        public string Answer1 { get; set; }
        public string Answer2 { get; set; }
        public string Answer3 { get; set; }
        public string Answer4 { get; set; }
        public string Answer5 { get; set; }
        public string Answer6 { get; set; }
        public string Answer7 { get; set; }
        public string Answer8 { get; set; }
        public string Answer9 { get; set; }
        public string Answer10 { get; set; }
        public string Answer11 { get; set; }
        public string Answer12 { get; set; }
        public string Answer13 { get; set; }
        public string Answer14 { get; set; }
        public string Answer15 { get; set; }

    }
}
