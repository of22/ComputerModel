using ComputerModel.Hardware.Abstract;

namespace ComputerModel.Hardware.Concrete
{
    public class ZalmanOptima : CpuFan
    {
        public ZalmanOptima(int rpm) : base(rpm)
        {
        }
    }
}
