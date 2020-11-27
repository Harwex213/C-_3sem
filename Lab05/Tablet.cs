using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab05
{
    class Tablet : Technic, IDevice
    {
        // 1095 days == 3 years.
        public override TimeSpan OperationPeriod { get; set; } = new TimeSpan(1095, 0, 0, 0);
        public override TimeSpan CurrentOperationPeriod { get; set; } = new TimeSpan(0, 0, 0, 0);
        public int RezolutionHeight { get; set; } = 720;
        public int RezolutionWidth { get; set; } = 1280;
        public int AmountOfRAM { get; set; } = 4;
        public string TypeOfCPU { get; set; } = "AMD";

        public void Reboot()
        {
            Console.WriteLine("*** Reboo-o-o-ot... ***");
        }

        public void TurnOff()
        {
            Console.WriteLine("*** The tablet will shut down right now! ***");
        }

        public override void TurnOn()
        {
            Console.WriteLine("*** The tablet was just started! ***");
        }

        public override string ToString()
        {
            return base.ToString() + "This Tablet is very Comfortable!";
        }
    }
}
