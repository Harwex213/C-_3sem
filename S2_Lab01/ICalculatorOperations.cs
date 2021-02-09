using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S2_Lab01
{
    interface ICalculatorOperations
    {
        double Grades { get; set; }
        // Memory Save & Out.
        void MemoryIn(double value);
        void MemoryOut(double value);
        // Trigonometry.
        double Sin();
        double Cos();
        double Tan();
        double Cot();
        double ArcSin();
        double ArcCos();
        double ArcTan();
        double ArcCot();
    }
}
