using System;
using ComputerModel.Enums;
using ComputerModel.Hardware.Abstract;
using ComputerModel.Hardware.Interfaces;

namespace ComputerModel.Hardware.Concrete
{
    public class ZalmanOptima : CpuFan, ICooling, IRunnable
    {
        public ZalmanOptima()
        {
            Rpm = 100;
            CoolingCharestiristics = CoolingCharestiristics.Pressure;
        }

        private int rpm;
        public int Rpm {
            get
            {
                return rpm;
            }
            set
            {
                Console.WriteLine("Rpm value is set to " + value);
                rpm = value;
            }
        }
        public void Start()
        {
            Console.WriteLine("Started CPU fan");
        }

        public void Stop()
        {
            Console.WriteLine("Stopped CPU fan");
        }
    }
}
