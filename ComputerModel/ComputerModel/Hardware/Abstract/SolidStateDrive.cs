using System;
using ComputerModel.Interfaces;

namespace ComputerModel.Hardware.Abstract
{
    public abstract class SolidStateDrive :IRunnable
    {
        protected SolidStateDrive(long volume)
        {
            Volume = volume;
        }

        public long Volume { get; }

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
