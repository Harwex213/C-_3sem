using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace S2_Lab02
{
    public partial class MainForm : Form
    {
        private List<Plane> _planes;
        private List<CrewMember> _crew;

        public MainForm()
        {
            InitializeComponent();
            _planes = new List<Plane>();
            _crew = new List<CrewMember>();
            AirYearReleaseDatePicker.Format = DateTimePickerFormat.Custom;
            AirTechServiceDatePicker.Format = DateTimePickerFormat.Custom;
            AirYearReleaseDatePicker.CustomFormat = "dd.MM.yyyy";
            AirTechServiceDatePicker.CustomFormat = "dd.MM.yyyy";
        }
        
        private void RefreshCrew()
        {
            _crew = new List<CrewMember>();
        }

        private void RefreshCrewAmount()
        {
            
            CrewMemberIdLabel.Text = CrewMemberIdLabel.Text.Remove(10);
            CrewMemberIdLabel.Text = CrewMemberIdLabel.Text.Insert(10, Convert.ToString(_crew.Count));
        }

        private static bool Validate(object plane)
        {
            var results = new List<ValidationResult>();
            var resultString = "";
            var resultOfValidation = Validator.TryValidateObject(plane, new ValidationContext(plane), results, true);
            if (resultOfValidation)
            {
                resultString = "Объет успешно добавлен.";
            }
            else
            {
                foreach (var error in results)
                    resultString += error + "\n";
            }
            MessageBox.Show(resultString, "Результат");
            return resultOfValidation;
        }

        private void AirAddButton_Click(object sender, EventArgs e)
        {
            var plane = new Plane(_crew)
            {
                Model = AirModelList.Text,
                DateRelease = AirYearReleaseDatePicker.Text,
                DateTechService = AirTechServiceDatePicker.Text,
                LoadCapacity = Convert.ToInt32(AirLoadCapacitySetter.Text),
                PassengersSeatsAmount =  Convert.ToInt32(AirPassengersSeatsSetter.Text),
                CrewAmount = Convert.ToInt32(AirCrewAmountSetter.Text)
            };
            int.TryParse(AirIdInput.Text, out var id);
            plane.Id = id;
            if (AirTypeCargo.Checked)
                plane.Type = AirTypeCargo.Text;
            else if (AirTypePassenger.Checked)
                plane.Type = AirTypePassenger.Text;
            else if (AirTypeMilitary.Checked)
                plane.Type = AirTypePassenger.Text;

            if (!Validate(plane)) 
                return;
            
            _planes.Add(plane);
            RefreshCrew();
            RefreshCrewAmount();
        }

        private void AirFormCleanButton_Click(object sender, EventArgs e)
        {
            AirIdInput.Text = "";
            AirModelList.Text = "";
            AirTypeCargo.Checked = false;
            AirTypePassenger.Checked = false;
            AirTypeMilitary.Checked = false;
            AirYearReleaseDatePicker.Value = DateTime.Today;
            AirTechServiceDatePicker.Value = DateTime.Today;
            AirLoadCapacitySetter.Text = "10";
            AirPassengersSeatsSetter.Text = "10";
            AirCrewAmountSetter.Text = "1";
        }

        private void CrewMemberAddButton_Click(object sender, EventArgs e)
        {
            var crewMember = new CrewMember()
            {
                Age = Convert.ToInt32(CrewMemberAgeSetter.Text),
                WorkExperience = Convert.ToInt32(CrewMemberWorkExperienceSetter.Text),
                FirstName = CrewMemberNameInput.Text,
                LastName = CrewMemberSurnameInput.Text,
                Patronymic = CrewMemberPatronymicInput.Text,
                Position = CrewMemberPositionList.Text
            };

            if (!Validate(crewMember))
                return;
            
            _crew.Add(crewMember);
            RefreshCrewAmount();
        }

        private void CrewMemberDeleteButton_Click(object sender, EventArgs e)
        {
            if (_crew.Count == 0) 
                return;
            _crew.RemoveAt(_crew.Count - 1);
            RefreshCrewAmount();
        }

        private void CrewDeleteButton_Click(object sender, EventArgs e)
        {
            RefreshCrew();
            RefreshCrewAmount();
        }

        private void DataSaveButton_Click(object sender, EventArgs e)
        {
            var json = JsonConvert.SerializeObject(_planes);
            using var streamWriter = new StreamWriter(@"data/save.json");
            streamWriter.Write(json);
            MessageBox.Show("Данные успешно сохранены.");
        }

        private void DataReadButton_Click(object sender, EventArgs e)
        {
            using var streamReader = new StreamReader(@"data/save.json");
            var json = streamReader.ReadToEnd();
            _planes = JsonConvert.DeserializeObject<List<Plane>>(json);
            MessageBox.Show("Данные успешно считаны.");
        }
    }
}