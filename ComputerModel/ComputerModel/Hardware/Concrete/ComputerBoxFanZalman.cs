﻿namespace ComputerModel.Hardware.Concrete
{
    using System;
    using Enums;
    using Interfaces;

    class ComputerBoxFanZalman : IFan
    {
        public ComputerBoxFanZalman()
        {
            CoolingCharestiristics = CoolingCharestiristics.Flow;
        }

        public void Start()
        {
            Console.WriteLine("Started computerBoxFan");
        }

        public void Stop()
        {
            Console.WriteLine("Stopped computerBoxFan");
        }

        public int Rpm { get; set; }
        public CoolingCharestiristics CoolingCharestiristics { get; }
    }
}
