namespace ComputerModel.Hardware.Interfaces
{
    using ComputerModel.Interfaces;

    public interface IGpu : ICalculateable, IRunnable
    {
        IFan Fan { get; }

        int GHz { get; }

        int Voltage { get; }

        int Rpm { get; set; }

    }
}
