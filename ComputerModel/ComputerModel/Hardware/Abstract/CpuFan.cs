using System;
using ComputerModel.Enums;
using ComputerModel.Interfaces;

namespace ComputerModel.Hardware.Abstract
{
    public abstract class CpuFan : IRunnable, ICooling
    {
        protected CpuFan(int rpm)
        {
            CoolingCharestiristics = CoolingCharestiristics.Pressure;
            Rpm = rpm;
        }

        CoolingCharestiristics CoolingCharestiristics { get; }

        public void Start()
        {
            Console.WriteLine("Started CPU fan");
        }

        public void Stop()
        {
            Console.WriteLine("Stopped CPU fan");
        }

        public int Rpm { get; set; }
    }
}
