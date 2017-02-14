using System;
using ComputerModel.Interfaces;

namespace ComputerModel.Hardware.Abstract
{
    public abstract class Cpu : IRunnable, ICalculateable
    {
        protected Cpu( int ghz, int cores)
        {
            GHz = ghz;
            Cores = cores;
        }
        
         int GHz { get; }

         int Cores { get; }

        public void Start()
        {
            Console.WriteLine("Powered on Cpu ");
        }

        public void Stop()
        {
            Console.WriteLine("Powered off cpu");
        }

        public void InitializeProcessingUnit()
        {
            Console.WriteLine("Initialized Cpu");
        }

        public void TurnOffProcessingUnit()
        {
            Console.WriteLine("Turned off Cpu processing");
        }
    
    }
}
