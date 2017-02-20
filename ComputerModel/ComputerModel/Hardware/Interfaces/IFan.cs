namespace ComputerModel.Hardware.Interfaces
{
    using ComputerModel.Interfaces;
    using Enums;

    public interface IFan : ICoolable, IRunnable
    {
        CoolingCharestiristics CoolingCharestiristics { get; }
    }
}
