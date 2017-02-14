using System;
using ComputerModel.Hardware.Abstract;

namespace ComputerModel.Hardware.Concrete
{
    public class ComputerBoxZalmanZ11 : ComputerBox
    {
        public ComputerBoxZalmanZ11(Motherboard motherboard, ComputerBoxFan computerBoxFan, PowerSupply powerSupply) : base(motherboard, computerBoxFan, powerSupply)
        {          
        }

        public void ChangeState()
        {
            Console.WriteLine("Pressed power button");       
        }
    }
}
