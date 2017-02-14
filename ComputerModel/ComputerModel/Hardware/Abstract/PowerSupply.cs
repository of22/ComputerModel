using System;
using ComputerModel.Interfaces;

namespace ComputerModel.Hardware.Abstract
{
    public abstract class PowerSupply : IRunnable
    {
        protected PowerSupply(int power)
        {
            Power = power;
        }

        public int Power { get; }

        public void Start()
        {
            Console.WriteLine("Turned on power supply");
            Console.WriteLine($"Power supply power =  {Power} watt");
        }

        public void Stop()
        {
            Console.WriteLine("Turned off power supply");
        }

    }
}
