using ComputerModel.Hardware.Abstract;

namespace ComputerModel.Interfaces
{
    public interface IManageable
    {
        void StartHardware(Motherboard motherboard);
    }
}
