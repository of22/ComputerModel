namespace ComputerModel.Hardware.Interfaces
{
    using ComputerModel.Interfaces;
    using Software.Abstract;

    public interface IMotherboard : IRunnable
    {
        ICpu Cpu { get; }
        IRam Ram { get; }
        IFan CpuFan { get; }
        ISolidStateDrive SolidStateDrive { get; }
        IGpu Gpu { get; }
        IBios Bios { get; }

    }
}
