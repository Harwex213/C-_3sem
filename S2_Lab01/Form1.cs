using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace S2_Lab01
{
    public partial class Calculator : Form, ICalculatorOperations
    {
        public Calculator()
        {
            InitializeComponent();
        }
        private bool minusExist = false;
        private bool pointExist = false;
        public double Grades { get; set; }
        private double valueSave = 0;
        private string unlessText;
        Stack<double> memory = new Stack<double>();

        #region InterfaceRealization
        public double Sin()
        {
            return Math.Sin(Grades);
        }
        public double Cos()
        {
            return Math.Cos(Grades);
        }
        public double Tan()
        {
            return Math.Tan(Grades);
        }
        public double Cot()
        {
            return 1/Math.Tan(Grades);
        }
        public double ArcSin()
        {
            return Math.Asin(Grades);
        }
        public double ArcCos()
        {
            return Math.Acos(Grades);
        }
        public double ArcTan()
        {
            return Math.Atan(Grades);
        }

        public double ArcCot()
        {
            return Math.Atan(1/Grades);
        }
        #endregion

        public void MemoryIn(double value)
        {
            memory.Push(value);
        }
        public double MemoryOut()
        {
            return memory.Pop();
        }
        private void ButtonNumber_Click(object sender, EventArgs e)
        {
            EraseError();
            try
            {
                char button = Convert.ToChar(((Button)sender).Text);
                switch (button)
                {
                    case '0':
                        DataOut.Text += '0';
                        break;
                    case '1':
                        DataOut.Text += '1';
                        break;
                    case '2':
                        DataOut.Text += '2';
                        break;
                    case '3':
                        DataOut.Text += '3';
                        break;
                    case '4':
                        DataOut.Text += '4';
                        break;
                    case '5':
                        DataOut.Text += '5';
                        break;
                    case '6':
                        DataOut.Text += '6';
                        break;
                    case '7':
                        DataOut.Text += '7';
                        break;
                    case '8':
                        DataOut.Text += '8';
                        break;
                    case '9':
                        DataOut.Text += '9';
                        break;
                    case '.':
                        if (!pointExist)
                        {
                            DataOut.Text += '.';
                            pointExist = true;
                        }
                        else
                        {
                            pointExist = false;
                            throw new Exception();
                        }
                        break;
                }
            }
            catch (Exception)
            {
                Error();
            }
        }
        private void ButtonMinus_Click(object sender, EventArgs e)
        {
            EraseError();
            if (DataOut.Text.Length > 0)
            {
                if (!minusExist)
                {
                    if (!DataOut.Text.Contains("^"))
                        DataOut.Text = DataOut.Text.Insert(0, "-");
                    minusExist = true;
                }
                else
                {
                    DataOut.Text = DataOut.Text.Replace("-", "");
                    minusExist = false;
                }
            }
        }
        private void ButtonPow_Click(object sender, EventArgs e)
        {
            EraseError();
            try
            {
                char button = Convert.ToChar(((Button)sender).Text.Last());
                double value = Convert.ToDouble(DataOut.Text);
                switch (button)
                {
                    case '^':
                        DataOut.Text += '^';
                        valueSave = value;
                        unlessText = DataOut.Text;
                        break;
                    case '2':
                        DataOut.Text = Convert.ToString(Math.Pow(value, 2));
                        break;
                    case '3':
                        DataOut.Text = Convert.ToString(Math.Pow(value, 3));
                        break;
                }
            }
            catch (Exception)
            {
                Error();
            }
        }
        private void ButtonReset_Click(object sender, EventArgs e)
        {
            DataOut.Text = "";
        }
        private void ButtonEnter_Click(object sender, EventArgs e)
        {
            EraseError();
            try
            {
                double value = Convert.ToDouble(DataOut.Text.Replace(unlessText, ""));
                DataOut.Text = Convert.ToString(Math.Pow(valueSave, value));
            }
            catch (Exception)
            {
                Error();
            }
        }
        private void ButtonTrigonometry_Click(object sender, EventArgs e)
        {
            EraseError();
            try
            {
                Grades = Convert.ToDouble(DataOut.Text);
                switch (((Button)sender).Text)
                {
                    case "sin":
                        DataOut.Text = Sin().ToString();
                        break;
                    case "cos":
                        DataOut.Text = Cos().ToString();
                        break;
                    case "tan":
                        DataOut.Text = Tan().ToString();
                        break;
                    case "cot":
                        DataOut.Text = Cot().ToString();
                        break;
                    case "arcsin":
                        DataOut.Text = ArcSin().ToString();
                        break;
                    case "arccos":
                        DataOut.Text = ArcCos().ToString();
                        break;
                    case "arctan":
                        DataOut.Text = ArcTan().ToString();
                        break;
                    case "arccot":
                        DataOut.Text = ArcCot().ToString();
                        break;
                }
            }
            catch (Exception)
            {
                Error();
            }
        }
        private void ButtonMemoryIn_Click(object sender, EventArgs e)
        {
            EraseError();
            try
            {
                MemoryIn(Convert.ToDouble(DataOut.Text));
            }
            catch (Exception)
            {
                Error();
            }
        }
        private void ButtonMemoryOut_Click(object sender, EventArgs e)
        {
            EraseError();
            try
            {
                DataOut.Text = MemoryOut().ToString();
            }
            catch (Exception)
            {
                Error();
            }
        }
        private void Error()
        {
            DataOut.Text = "Некорректный ввод данных";
        }
        private void EraseError()
        {
            if (DataOut.Text == "Некорректный ввод данных")
                DataOut.Text = "";
        }
    }
}
