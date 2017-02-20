namespace ComputerModel.Hardware.Interfaces
{
    using ComputerModel.Interfaces;

    public interface IComputerBox : IRunnable
    {
        void PowerOnAndInitBios(IMotherboard motherboard);

    }
}
