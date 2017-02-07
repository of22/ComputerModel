using System;
using ComputerModel.Hardware.Abstract;
using ComputerModel.Hardware.Interfaces;

namespace ComputerModel.Hardware.Concrete
{
    public class SamsungSsd : SolidStateDrive, IRunnable
    {
        public SamsungSsd()
        {
            Volume = 123;
        }

        public void Start()
        {
            Console.WriteLine("SSD started");
        }

        public void Stop()
        {
            Console.WriteLine("SSD stopped");
        }
    }
}
