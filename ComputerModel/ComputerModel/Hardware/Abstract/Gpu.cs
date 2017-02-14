using System;
using ComputerModel.Interfaces;

namespace ComputerModel.Hardware.Abstract
{
    public abstract class Gpu : ICooling, ICalculateable, IRunnable
    {
        protected Gpu( int rpm, int voltage, int ghz)
        {
            GHz = ghz;
            Voltage = voltage;
            Rpm = rpm;
        }

        int GHz { get; }

        int Voltage { get; }

        public int Rpm { get; set; }

        public void InitializeProcessingUnit()
        {
            Console.WriteLine("GPU is ready for use");
        }

        public void TurnOffProcessingUnit()
        {
            Console.WriteLine("Powered off GPU");
        }

        public void Start()
        {
            Console.WriteLine("Started Gpu");
            Console.WriteLine("Started GPU cooler");
        }

        public void Stop()
        {
            Console.WriteLine("Stopped Gpu");
        }
    }
}
