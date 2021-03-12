using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Globalization;

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
        public DateTime DateRelease { get; set; }
        public DateTime DateTechService { get; set; }
        public int LoadCapacity { get; set; }
        public int PassengersSeatsAmount { get; set; }
        public int CrewAmount { get; set; }
        [Compare("CrewAmount", ErrorMessage = "Созданное количество членов экипажа не соотвествует их ожидаемому числу")]
        public int CrewActualAmount { get; }
        public List<CrewMember> Crew { get; }

        public Plane()
        {
            Crew = new List<CrewMember>();
        }
        
        public Plane(List<CrewMember> listCrew)
        {
            Crew = listCrew;
            CrewActualAmount = Crew.Count;
        }

        public override string ToString()
        {
            var crewToString = "";

            foreach (var crewMember in Crew)
            {
                crewToString = crewToString + "--------\r\n" +
                               $"\tFirstname: {crewMember.FirstName}\r\n" +
                               $"\tLastname: {crewMember.LastName}\r\n" +
                               $"\tPatronymic: {crewMember.Patronymic}.\r\n" +
                               $"\tAge: {crewMember.Age}.\r\n" +
                               $"\tWorkExp: {crewMember.WorkExperience}.\r\n" +
                               $"\tPosition: {crewMember.Position}.\r\n" +
                               "--------\r\n";
            }
            return $"\r\n//////Самолёт {Id}//////\r\n" +
                   $"Тип: {Type}\r\n" +
                   $"Модель: {Model}\r\n" +
                   $"Дата выпуска: {DateRelease:dd.MM.yyyy}\r\n" +
                   $"Дата тех. обслуживания: {DateTechService:dd.MM.yyyy}\r\n" +
                   $"Грузоподъёмность: {LoadCapacity}\r\n" +
                   $"Пассажирские места: {PassengersSeatsAmount}\r\n" +
                   $"\tЭкипаж:\r\n" + crewToString +
                   "\r\n////////////\r\n";
            // return "//////////////////////////////////////////////\n" +
            //        "Самолёт\t" + Id + "\n" +
            //        "Тип\t" + Type + "\n" +
            //        "Модель:\t" + Model + "\n" +
            //        "Дата выпуска:\t" + "\n" +
            //        "Дата тех. обслуживания:\t" + "\n" +
            //        "Грузоподъёмность:\t" + "\n" +
            //        "Пассажирские места\t" + "\n" +
            //        "Экипаж:\n" + crewToString + "\n" +
            //        "//////////////////////////////////////////////\n";
        }
    }
}