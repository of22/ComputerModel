using ComputerModel.Hardware.Abstract;

namespace ComputerModel.Hardware.Concrete
{
    public class SamsungSsd : SolidStateDrive
    {
        public SamsungSsd() : base(240)
        {
        }
    }
}
