using ComputerModel.Hardware.Abstract;

namespace ComputerModel.Software.Interfaces
{
    public interface IManageable
    {
        void StartHardware(Motherboard motherboard);

        void BiosInit();

        void ChangeFanRpm();

        void OverHeatShutdown();
    }
}
