namespace ComputerModel.Hardware.Concrete
{
    using System;
    using Enums;
    using Interfaces;

    public class ZalmanOptima : IFan
    {
        public ZalmanOptima()
        {
            Rpm = 100;
            CoolingCharestiristics = CoolingCharestiristics.Pressure;
        }

        public void Start()
        {
            Console.WriteLine("Started CPU fan");
        }

        public void Stop()
        {
            Console.WriteLine("Stopped CPU fan");
        }

        public int Rpm { get; set; }
        public CoolingCharestiristics CoolingCharestiristics { get; }
    }
}
