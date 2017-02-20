using ComputerModel.Software.Abstract;

namespace ComputerModel.Software.Concrete
{
    using System;
    using Hardware.Interfaces;

    public class AsrockBios : IBios
    {
        public AsrockBios()
        {
            BiosVersion = 2;
        }

        public void Start(IMotherboard element)
        {
            Console.WriteLine("***** Turned on BIOS ******");
            PrintBiosVersion();

            element.CpuFan.Start();
            element.Cpu.Start();
            element.Ram.Start();
            element.SolidStateDrive.Start();
            element.Gpu.Start();
            element.Gpu.InitializeProcessingUnit();

        }

        public void Stop(IMotherboard item)
        {
            Console.WriteLine("Stopped Bios");
        }

        public int BiosVersion { get; set; }
        public void PrintBiosVersion()
        {
            Console.WriteLine("***** Bios Version : " + BiosVersion + " ****");
        }
    }
}
