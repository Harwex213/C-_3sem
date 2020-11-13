using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab05
{
    class Plotter : PrintingDevice
    {
        public override int PrintingSpeed { get; set; } = 150;
        public override string ToString()
        {
            return base.ToString() + "It's very good question what is Plotter...";
        }
    }
}
