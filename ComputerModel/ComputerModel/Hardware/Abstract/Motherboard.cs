using System;
using ComputerModel.Interfaces;
using ComputerModel.Software.Abstract;

namespace ComputerModel.Hardware.Abstract
{
    public abstract class Motherboard : IRunnable
    {
        protected Motherboard( Cpu cpu, Ram ram, CpuFan cpuFan, SolidStateDrive solidStateDrive, Gpu gpu, Bios bios)
        {
            Cpu = cpu;
            Ram = ram;
            CpuFan = cpuFan;
            SolidStateDrive = solidStateDrive;
            Gpu = gpu;
            Bios = bios;
        }
        public Cpu Cpu { get; }
        public Ram Ram { get; }
        public CpuFan CpuFan { get; }
        public SolidStateDrive SolidStateDrive { get; }
        public Gpu Gpu { get; }
        public Bios Bios { get; }

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
