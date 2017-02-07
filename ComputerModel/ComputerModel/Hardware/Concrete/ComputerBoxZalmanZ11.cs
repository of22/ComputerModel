using System;
using ComputerModel.Hardware.Abstract;
using ComputerModel.Hardware.Interfaces;

namespace ComputerModel.Hardware.Concrete
{
    public class ComputerBoxZalmanZ11 : ComputerBox, IRunnable,ICooling
    {
        public ComputerBoxZalmanZ11()
        {
            motherboard = new 
            
        }

        public string PowerState { get; set; }
        public void ChangeState()
        {
            Console.WriteLine("Pressed power button");
            
        }

        public string Rpm { get; set; }
        public string CoolerState { get; set; }


        public void Start()
        {
            Console.WriteLine("Started Computer box Fan ");
        }

        public void Stop()
        {
            Console.WriteLine("Stopped Computer box Fan");
        }

        private int rpm;
        int ICooling.Rpm
        {
            get { return rpm; }
            set { Console.WriteLine("Computer box fan Rpm is set to " + value); }
        }
    }
}
