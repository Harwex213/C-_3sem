using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab05
{
    abstract class Technic : Product
    {
        public abstract TimeSpan OperationPeriod { get; set; }

        public abstract void TurnOn();

        public override string ToString()
        {
            return base.ToString() + $"Operation Period is {OperationPeriod.Days} days.\n";
        }
    }
}
