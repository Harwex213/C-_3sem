using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Globalization;

namespace S2_Lab02
{
    public class Plane
    {
        private static int _nextId;
        
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
        public List<CrewMember> Crew { get; private set; }

        public Plane()
        {
            Crew = new List<CrewMember>();
        }

        public Plane(IPlaneFactory planeFactory) : this()
        {
            Type = planeFactory.CreateType().Name;
            Model = planeFactory.CreateModel().Name;
        }
        
        public Plane(List<CrewMember> listCrew)
        {
            Crew = listCrew;
            CrewActualAmount = Crew.Count;
        }

        public Plane(List<CrewMember> listCrew, IPlaneFactory planeFactory) : this(planeFactory)
        {
            Crew = listCrew;
            CrewActualAmount = Crew.Count;
        }

        public void GenerateNewData()
        {
            Id = _nextId++;
            DateRelease = DateTime.Now;
            DateTechService = DateTime.Now;
            LoadCapacity = 100;
            PassengersSeatsAmount = 100;
            CrewAmount = 2;
            Crew = new List<CrewMember>();
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
        }
    }
}