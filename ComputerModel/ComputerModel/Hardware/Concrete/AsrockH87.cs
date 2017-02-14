using ComputerModel.Hardware.Abstract;
using ComputerModel.Software.Abstract;


namespace ComputerModel.Hardware.Concrete
{
    public class AsrockH87 : Motherboard
    {
        public AsrockH87(Cpu cpu, Ram ram, CpuFan cpuFan, SolidStateDrive solidStateDrive, Gpu gpu,Bios bios) : base(cpu, ram, cpuFan, solidStateDrive, gpu, bios)
        {
        }
    }
}
