namespace ComputerModel.Hardware.Interfaces
{
    using ComputerModel.Interfaces;

    public interface IRam : IRunnable
    { 
        int Timings { get; set; }

        int MHz { get; set; }

        int Volume { get; set; }

    }
}
