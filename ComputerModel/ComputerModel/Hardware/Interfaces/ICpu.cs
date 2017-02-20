namespace ComputerModel.Hardware.Interfaces
{
    using ComputerModel.Interfaces;

    public interface ICpu : IRunnable, ICalculateable
    {     
        int GHz { get; }

        int Cores { get; }
    }
}
