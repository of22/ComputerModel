namespace ComputerModel.Hardware.Interfaces
{
    using ComputerModel.Interfaces;

    public interface ISolidStateDrive :IRunnable
    {
        long Volume { get; }
    }   
}
