using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab05
{
    interface IDevice
    {
        int RezolutionHeight { get; set; }
        int RezolutionWidth { get; set; }
        int AmountOfRAM { get; set; }
        string TypeOfCPU { get; set; }
        void TurnOn();
        void Reboot();
        void TurnOff();
    }
}
