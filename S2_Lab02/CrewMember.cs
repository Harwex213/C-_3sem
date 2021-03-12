using System.ComponentModel.DataAnnotations;

namespace S2_Lab02
{
    public class CrewMember
    {
        [Required(ErrorMessage = "Имя должно быть задано")]
        [StringLength(15, ErrorMessage = "Имя слишком длинное")]
        [RegularExpression("([A-Z]{1}[a-z]*)|([А-Я]{1}[а-я]*)", ErrorMessage = "Имя задано неверно.")]
        public string FirstName { get; set; }
        [Required(ErrorMessage = "Фамилия должна быть задана")]
        [StringLength(30, ErrorMessage = "Фамилия слишком длинная")]
        [RegularExpression("([A-Z]{1}[a-z]*)|([А-Я]{1}[а-я]*)", ErrorMessage = "Фамилия задана неверно.")]
        public string LastName { get; set; }
        [Required(ErrorMessage = "Отчество должно быть задано")]
        [StringLength(30, ErrorMessage = "Отчество слишком длинное")]
        [RegularExpression(@"([A-Z]{1}[a-z]*)|([А-Я]{1}[а-я]*)", ErrorMessage = "Отчество задано неверно.")]
        public string Patronymic { get; set; }
        public int Age { get; set; }
        public int WorkExperience { get; set; }
        [Required(ErrorMessage = "Должность должна быть задана")]
        [StringLength(30, ErrorMessage = "Название должности слишком длинное")]
        [RegularExpression(@"([А-Я]{1}(([а-я]*)|(\s*))+)", ErrorMessage = "Название должности задано неверно.")]
        public string Position { get; set; }
    }
}