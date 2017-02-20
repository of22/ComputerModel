namespace ComputerModel.Hardware.Concrete
{
    using System;
    using Enums;
    using Interfaces;

    class AsusGpuFan : IFan
    {
        public AsusGpuFan()
        {
            Rpm = 100;
            CoolingCharestiristics = CoolingCharestiristics.Flow;
        }
        public int Rpm { get; set; }
        public CoolingCharestiristics CoolingCharestiristics { get; }

        public void Start()
        {
            Console.WriteLine("Started computerBoxFan");
        }

        public void Stop()
        {
            Console.WriteLine("Stopped computerBoxFan");
        }

    }
}
