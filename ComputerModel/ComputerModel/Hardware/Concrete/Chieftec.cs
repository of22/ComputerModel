using System;
using ComputerModel.Hardware.Abstract;
using ComputerModel.Hardware.Interfaces;

namespace ComputerModel.Hardware.Concrete
{
    public class Chieftec : PowerSupply, IRunnable
    {
        public Chieftec()
        {
            Power = 400;       
        }

        public void Start()
        {
            Console.WriteLine("Turned on power supply");
        }

        public void Stop()
        {
            Console.WriteLine("Turned off power supply");
        }

    }
}
