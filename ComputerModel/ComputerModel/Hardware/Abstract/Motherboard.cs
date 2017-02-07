using ComputerModel.Hardware.Interfaces;
using ComputerModel.Software.Interfaces;

namespace ComputerModel.Hardware.Abstract
{
    public abstract class Motherboard
    {
        public Cpu Cpu;
        public Ram Ram;
        public CpuFan CpuFan;
        public ComputerBoxFan ComputerBoxFan;
        public SolidStateDrive SolidStateDrive;
        public Bios Bios;

        public abstract void InitBios();

    }
}
