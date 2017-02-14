using System;
using ComputerModel.Interfaces;

namespace ComputerModel.Hardware.Abstract
{
    public abstract class ComputerBox : IRunnable
    {
        private readonly Motherboard _motherboard;
        private readonly ComputerBoxFan _computerBoxFan;
        private readonly PowerSupply _powerSupply;

        protected ComputerBox(Motherboard motherboard, ComputerBoxFan computerBoxFan, PowerSupply powerSupply)
        {
            _motherboard = motherboard;
            _computerBoxFan = computerBoxFan;
            _powerSupply = powerSupply;
        }

        public void Start()
        {
            Console.WriteLine("Started Computer");
        }

        public void Stop()
        {
            Console.WriteLine("Stopped Computer");
        }

        public void InitHardware()
        {
            _powerSupply.Start();
            _computerBoxFan.Start();
            _motherboard.Start();
            _motherboard.Bios.Start();
            _motherboard.Bios.PrintBiosVersion();
            _motherboard.Bios.StartHardware(_motherboard);

            Console.WriteLine("***** Turned on computer ******");
        }
    }
}
