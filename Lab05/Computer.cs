using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab05
{
    class Computer : Technic, IDevice
    {
        // 1825 days == 5 years.
        public override TimeSpan OperationPeriod { get; set; } = new TimeSpan(1825, 0, 0, 0);
        public int RezolutionHeight { get; set; } = 1080;
        public int RezolutionWidth { get; set; } = 1920;
        public int AmountOfRAM { get; set; } = 16;
        public string TypeOfCPU { get; set; } = "Intel";
        public void Reboot()
        {
            Console.WriteLine("*** Reboo-o-o-ot... ***");
        }
        public void TurnOff()
        {
            Console.WriteLine("*** The computer will shut down right now! ***");
        }
        public override void TurnOn()
        {
            Console.WriteLine("*** The computer was just started! ***");
        }
        void IDevice.TurnOn()
        {
            Console.WriteLine("Interface IDevice is on!");
            Console.WriteLine("*** The computer was just started! ***");
        }
        public override string ToString()
        {
            return base.ToString() + "This Computer is very powerful!";
        }
    }
}
