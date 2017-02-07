using System;
using ComputerModel.Hardware.Interfaces;

namespace ComputerModel.Hardware.Concrete
{
    class IntelXeon : Cpu, IRunnable, ICalculateable
    {
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
            ;
        }

        public void TurnOffProcessingUnit()
        {
            Console.WriteLine("Turned off Cpu processing");
        }
    }
}
