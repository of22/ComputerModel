namespace ComputerModel.Hardware.Interfaces
{
    using ComputerModel.Interfaces;

    public interface IPowerSupply : IRunnable
    {
        int Power { get; }
    }
}
