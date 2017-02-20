namespace ComputerModel.Hardware.Concrete
{
    using System;
    using Interfaces;
    using Software.Abstract;

    public class AsrockH87 : IMotherboard
    {
        public AsrockH87(ICpu cpu, IRam ram, IFan cpuFan, ISolidStateDrive solidStateDrive, IGpu gpu, IBios bios)
        {
            Cpu = cpu;
            Ram = ram;
            CpuFan = cpuFan;
            SolidStateDrive = solidStateDrive;
            Gpu = gpu;
            Bios = bios;
        }
        public ICpu Cpu { get; }
        public IRam Ram { get; }
        public IFan CpuFan { get; }
        public ISolidStateDrive SolidStateDrive { get; }
        public IGpu Gpu { get; }
        public IBios Bios { get; }

        public void Start()
        {
            Console.WriteLine("Motherboard started");
        }

        public void Stop()
        {
            Console.WriteLine("Motherboard stopped");
        }


    }
}
