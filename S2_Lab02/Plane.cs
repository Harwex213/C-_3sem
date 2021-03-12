using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace S2_Lab02
{
    public class Plane
    {
        [PlaneIdCheck]
        public int Id { get; set; }

        [Required(ErrorMessage = "Тип Самолёта должен быть задан.")]
        public string Type { get; set; }

        [Required(ErrorMessage = "Модель самолёта должна быть задана.")]
        [RegularExpression("([A-Z]{1}[a-z]*)|([А-Я]{1}[а-я]*)", ErrorMessage = "Название модели задано неверно.")]
        public string Model { get; set; }
        public string DateRelease { get; set; }
        public string DateTechService { get; set; }
        public int LoadCapacity { get; set; }
        public int PassengersSeatsAmount { get; set; }
        public int CrewAmount { get; set; }
        [Compare("CrewAmount", ErrorMessage = "Созданное количество членов экипажа не соотвествует их ожидаемому числу")]
        public int CrewActualAmount { get; }
        private List<CrewMember> Crew { get; }

        public Plane()
        {
            Crew = new List<CrewMember>();
        }
        
        public Plane(List<CrewMember> listCrew)
        {
            Crew = listCrew;
            CrewActualAmount = Crew.Count;
        }
    }
}