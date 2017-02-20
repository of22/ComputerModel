using ComputerModel.Interfaces;

namespace ComputerModel.Software.Abstract
{
    using Hardware.Interfaces;

    public interface IBios : IRunnable<IMotherboard>
    {
        int BiosVersion { get; set; }
        void PrintBiosVersion();     
    }
}
