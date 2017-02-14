using ComputerModel.Hardware.Abstract;

namespace ComputerModel.Hardware.Concrete
{
    public class KingstonRam : Ram
    {
        public KingstonRam() : base(10, 1600, 16)
        {
        }

    }
}
