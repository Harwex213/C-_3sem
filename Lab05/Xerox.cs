using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab05
{
    class Xerox : PrintingDevice
    {
        public override int PrintingSpeed { get; set; } = 100;
        public override string ToString()
        {
            return base.ToString() + "Xerox very promising printing Device";
        }
    }
}
