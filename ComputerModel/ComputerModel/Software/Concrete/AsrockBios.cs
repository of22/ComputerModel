using System;
using ComputerModel.Hardware.Abstract;
using ComputerModel.Hardware.Concrete;
using ComputerModel.Hardware.Interfaces;
using ComputerModel.Software.Interfaces;

namespace ComputerModel.Software.Concrete
{
    public class AsrockBios : Bios, IManageable, IRunnable
    {
        public AsrockBios()
        {
            Version = 122;
        }

        public void StartHardware(Motherboard motherboard)
        {
            AsrockH87.
        }

        public void BiosInit()
        {
            Start();
        }

        public void ChangeFanRpm()
        {
            //todo add change RPM;
        }

        public void OverHeatShutdown()
        {
            //todo add overheat shutdown;
        }

        public void Start()
        {
            Console.WriteLine("Bios started");
        }

        public void Stop()
        {
            Console.WriteLine("Bios stopped");
        }

    }
}
