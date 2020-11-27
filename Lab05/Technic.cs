using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab05
{
    abstract class Technic : Product, ICloneable, IComparable
    {
        public abstract TimeSpan OperationPeriod { get; set; }
        public abstract TimeSpan CurrentOperationPeriod { get; set; }
        public abstract void TurnOn();

        public override string ToString()
        {
            return base.ToString() + $"Operation Period is {OperationPeriod.Days - CurrentOperationPeriod.Days} days.\n";
        }

        public object Clone() => this.MemberwiseClone();

        int IComparable.CompareTo(object obj)
        {
            var temp = obj as Technic;
            if (temp != null)
            {
                if (this.Price > temp.Price)
                    return 1;
                if (this.Price < temp.Price)
                    return -1;
                else
                    return 0;
            }
            else throw new ArgumentException("It's not a Technic!");
        }
    }
}
