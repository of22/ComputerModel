using ComputerModel.Hardware.Abstract;

namespace ComputerModel.Hardware.Concrete
{
    class IntelXeon : Cpu
    {
        public IntelXeon() : base(5, 8) //TODO ask what is preferred way to keep these parameters 
        {
        }

    }
}
