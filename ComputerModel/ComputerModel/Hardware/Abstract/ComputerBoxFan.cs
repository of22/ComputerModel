using System;
using ComputerModel.Enums;
using ComputerModel.Interfaces;

namespace ComputerModel.Hardware.Abstract
{
    public abstract class ComputerBoxFan : ICooling
    {
        public readonly CoolingCharestiristics CoolingCharestiristics;

        protected ComputerBoxFan()
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

        public int Rpm
        {
            get { return Rpm; }
            set
            {
                if (value < 0) throw new ArgumentOutOfRangeException(nameof(value));
                Console.WriteLine($"RPM = {value}");
                Rpm = value;
            }
        }
    }
    
}
