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
        public double Grades { get; set; }
        private double valueSave = 0;
        public double Sin()
        {
            throw new NotImplementedException();
        }
        public double Cos()
        {
            throw new NotImplementedException();
        }
        public double Tan()
        {
            throw new NotImplementedException();
        }
        public double Cot()
        {
            throw new NotImplementedException();
        }
        public double ArcSin()
        {
            throw new NotImplementedException();
        }
        public double ArcCos()
        {
            throw new NotImplementedException();
        }
        public double ArcTan()
        {
            throw new NotImplementedException();
        }

        public double ArcCot()
        {
            throw new NotImplementedException();
        }

        public void MemoryIn(double value)
        {
            throw new NotImplementedException();
        }

        public void MemoryOut(double value)
        {
            throw new NotImplementedException();
        }
        private void ButtonNumber_Click(object sender, EventArgs e)
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
                    DataOut.Text += '.';
                    break;
            }
        }

        private void ButtonMinus_Click(object sender, EventArgs e)
        {
            if (!minusExist)
            {
                DataOut.Text = DataOut.Text.Insert(0, "-");
                minusExist = true;
            }
            else
            {
                DataOut.Text = DataOut.Text.Replace("-", "");
                minusExist = false;
            }
        }

        private void ButtonPow_Click(object sender, EventArgs e)
        {
            try
            {
                char button = Convert.ToChar(((Button)sender).Text.Last());
                double value = Convert.ToDouble(DataOut.Text);
                switch (button)
                {
                    case '^':
                        DataOut.Text += '^';
                        valueSave = value;
                        break;
                    case '2':
                        DataOut.Text = Convert.ToString(Math.Pow(value, 2));
                        break;
                    case '3':
                        DataOut.Text = Convert.ToString(Math.Pow(value, 2));
                        break;
                }
            }
            catch (Exception)
            {
                DataOut.Text = "Некорректный ввод данных";
            }
        }

        private void ButtonReset_Click(object sender, EventArgs e)
        {
            DataOut.Text = "";
        }

        private void ButtonEnter_Click(object sender, EventArgs e)
        {
            double value = Convert.ToDouble(DataOut.Text);
            DataOut.Text = Convert.ToString(Math.Pow(value, valueSave));
        }
    }
}
