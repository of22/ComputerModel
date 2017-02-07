using System;
using ComputerModel.Hardware.Interfaces;

namespace ComputerModel.Hardware.Concrete
{
    public class NVidia : Gpu, ICalculateable, ICooling, IRunnable
    {
        public NVidia()
        {
            GHz = 1200;
            Voltage = 12;
        }

        public void InitializeProcessingUnit()
        {
            Console.WriteLine("Powered on GPU");
        }

        public void TurnOffProcessingUnit()
        {
            Console.WriteLine("Powered off GPU");
        }

        private int rpm;
        public int Rpm
        {
            get
            {
                return rpm;
            }
            set
            {
                rpm = value;
            }
        }

        public void Start()
        {
            Console.WriteLine("Started Gpu");
        }

        public void Stop()
        {
            Console.WriteLine("Stopped Gpu");
        }
    }
}
