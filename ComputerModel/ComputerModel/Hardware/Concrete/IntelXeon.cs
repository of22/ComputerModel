namespace ComputerModel.Hardware.Concrete
{
    using System;
    using Interfaces;

    class IntelXeon : ICpu
    {
        public IntelXeon()
        {
            GHz = 5;
            Cores = 8;
        }

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

        public int GHz { get; }
        public int Cores { get; }
    }
}
