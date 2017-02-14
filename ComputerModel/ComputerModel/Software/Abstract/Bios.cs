using System;
using ComputerModel.Hardware.Abstract;
using ComputerModel.Interfaces;

namespace ComputerModel.Software.Abstract
{
    public abstract class Bios : IRunnable, IManageable
    {
        protected Bios(int version)
        {
            BiosVersion = version;
        }

        public int BiosVersion { get; set; }
        public void Start()
        {
            Console.WriteLine("Started Bios");
        }

        public void Stop()
        {
            Console.WriteLine("Stopped Bios");
        }

        public void PrintBiosVersion()
        {
            Console.WriteLine("Bios Version : " + BiosVersion);
        }

        public void StartHardware(Motherboard motherboard)
        {
            motherboard.CpuFan.Start();
            motherboard.Cpu.Start();
            motherboard.Ram.Start();
            motherboard.SolidStateDrive.Start();
            motherboard.Gpu.Start();
            motherboard.Gpu.InitializeProcessingUnit();
        }


    }
}
