using System;
using ComputerModel.Enums;
using ComputerModel.Hardware.Abstract;
using ComputerModel.Hardware.Interfaces;

namespace ComputerModel.Hardware.Concrete
{
    class ComputerBoxFanZalman : ComputerBoxFan, IRunnable, ICooling
    {
        public ComputerBoxFanZalman()
        {
            Rpm = 150;
            CoolingCharestiristics = CoolingCharestiristics.Flow;
        }

        public void Start()
        {
            Console.WriteLine("Started ComputerBox Fan");
        }

        public void Stop()
        {
            Console.WriteLine("Stopped ComputerBox Fan");
        }

        private int rpm;

        public int Rpm
        {
            get { return rpm; }
            set
            {
                Console.WriteLine("rpm was set to " + value);
            }
        }


    }
}
