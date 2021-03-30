using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.IO;
using System.Threading;
using System.Windows.Forms;
using Newtonsoft.Json;
using Timer = System.Threading.Timer;

namespace S2_Lab02
{
    public partial class MainForm : Form
    {
        public List<Plane> Planes { get; set; }
        private List<CrewMember> _crew;
        private List<int> _planesIdList;

        public MainForm()
        {
            InitializeComponent();
            AppSettings.GetInstance().DoSomething(this);
            
            Planes = new List<Plane>();
            _crew = new List<CrewMember>();
            _planesIdList = new List<int>();
            DataView.Nodes.Add("Airport","Аэропорт");
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

        private void AddPlaneToDataView(Plane plane)
        {
            // Добавляем узел Самолёт в узел Аэропот.
            DataView.Nodes["Airport"].Nodes.Add(plane.Id.ToString(), "Самолёт " + plane.Id);
            // Создаём ветви узла Самолёта.
            var nodeCrew = new TreeNode("Crew");
            var idCrewMember = 0;
            foreach (var crewMember in plane.Crew)
            {
                nodeCrew.Nodes.Add( idCrewMember.ToString(),crewMember.Position);
                var crewMemberNode = new TreeNode[]
                {
                    new("FirstName: " + crewMember.FirstName),
                    new("LastName: " + crewMember.LastName),
                    new("Patronymic: " + crewMember.Patronymic),
                    new("Age: " + crewMember.Age),
                    new("WorkExperience: " + crewMember.WorkExperience)
                };
                nodeCrew.Nodes[idCrewMember.ToString()].Nodes.AddRange(crewMemberNode);
                idCrewMember++;
            }

            var planeNode = new[]
            {
                new("Id: " + plane.Id),
                new("Model: " + plane.Model),
                new("Type: " + plane.Type),
                new("DateRelease: " + plane.DateRelease.ToString("dd.MM.yyyy")),
                new("DateTechService: " + plane.DateTechService),
                new("LoadCapacity: " + plane.LoadCapacity),
                new("SeatsAmount: " + plane.PassengersSeatsAmount),
                nodeCrew
            };
            // Добавляем ветви в узел.
            DataView.Nodes["Airport"].Nodes[plane.Id.ToString()].Nodes.AddRange(planeNode);

            StatusItemObjectsSetAmountLabel.Text = Planes.Count.ToString();
        }
        private void GenerateNewDataView()
        {
            DataView.Nodes["Airport"].Nodes.Clear();
            foreach (var plane in Planes)
                AddPlaneToDataView(plane);
        }

        private bool Validate(object plane)
        {
            var results = new List<ValidationResult>();
            var resultString = "";
            if (Validator.TryValidateObject(plane, new ValidationContext(plane), results, true))
            {
                if (plane is Plane tempPlane)
                {
                    resultString = !_planesIdList.Contains(tempPlane.Id) ?
                        "Объет успешно добавлен." :
                        "Самолёт с таким Id уже был добавлен раннее.";
                }
                else
                    resultString = "Объет успешно добавлен.";
            }
            else
            {
                foreach (var error in results)
                    resultString += error + "\n";
            }
            MessageBox.Show(resultString, "Результат");
            return resultString == "Объет успешно добавлен.";
        }

        private void AirAddButton_Click(object sender, EventArgs e)
        {
            var plane = new Plane(_crew)
            {
                Model = AirModelList.Text,
                DateRelease = AirYearReleaseDatePicker.Value,
                DateTechService = AirTechServiceDatePicker.Value,
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
            
            Planes.Add(plane);
            _planesIdList.Add(plane.Id);
            RefreshCrew();
            RefreshCrewAmount();
            AddPlaneToDataView(plane);
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
            CrewMemberNameInput.Text = "";
            CrewMemberSurnameInput.Text = "";
            CrewMemberPatronymicInput.Text = "";
            CrewMemberPositionList.Text = "";
            CrewMemberAgeSetter.Text = "18";
            CrewMemberWorkExperienceSetter.Text = "5";
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
            try
            {
                var json = JsonConvert.SerializeObject(Planes);
                using var streamWriter = new StreamWriter(@"data/save.json");
                streamWriter.Write(json);
                MessageBox.Show("Данные успешно сохранены.");
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void DataReadButton_Click(object sender, EventArgs e)
        {
            try
            {
                using var streamReader = new StreamReader(@"data/save.json");
                var json = streamReader.ReadToEnd();
                Planes = JsonConvert.DeserializeObject<List<Plane>>(json);
                MessageBox.Show("Данные успешно считаны.");
                GenerateNewDataView();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void DataViewClearButton_Click(object sender, EventArgs e)
        {
            DataView.Nodes["Airport"].Nodes.Clear();
            StatusItemObjectsSetAmountLabel.Text = "0";
        }

        private void AirSearchButton_Click(object sender, EventArgs e)
        {
            var searchForm = new Thread(() => Application.Run(new SearchForm(this)));
            searchForm.Start();
            Enabled = false;
        }

        private void MenuItemAboutProgram_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Version: 1.0\n Developer: Kaportsev O.A.");
        }
        
        private void AirGenerateButton_Click(object sender, EventArgs e)
        {
            Plane plane = null;

            var crewMemberBuilder = new CrewMemberBuilder();
            crewMemberBuilder.BuildFirstName("Oleg");
            crewMemberBuilder.BuildLastName("Kaportsev");
            crewMemberBuilder.BuildAge(19);
            crewMemberBuilder.BuildWorkExperience(5);
            crewMemberBuilder.BuildPosition("Пилот");

            var crewMember = crewMemberBuilder.GetProduct();

            #region PatternDecoratorUsing

            crewMember.Salary = new PilotSalary();
            crewMember.Salary = new FiveYearsWorkExperience(crewMember.Salary);
            crewMember.Salary = new FlightAce(crewMember.Salary);
            if (ShowSalaryCheckBox.Checked)
            {
                MessageBox.Show(@"Salary amount: " + crewMember.Salary.Cost());
            }

            #endregion

            var crew = new List<CrewMember>
            {
                crewMember,
                crewMember.Clone()
            };


            if (AirTypeCargo2.Checked)
                plane = new Plane(crew, new CargoPlaneFactory());
            else if (AirTypePassenger2.Checked)
                plane = new Plane(crew, new PassengerPlaneFactory());
            else if (AirTypeMilitary2.Checked)
                plane = new Plane(crew, new WarPlaneFactory());
            
            if (plane == null)
                return;
            
            for (int i = 0; i < AirAmountToGenerateSetter.Value; i++)
            {
                plane.GenerateNewData();
                AddPlaneToDataView(plane);
            }
        }
    }
}