using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab05
{
    abstract class PrintingDevice : Product 
    {
        public abstract int PrintingSpeed { get; set; }
        public override string ToString()
        {
            return base.ToString() + $"Printing Speed is {PrintingSpeed}. ";
        }
    }
}
