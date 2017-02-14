using System;
using ComputerModel.Hardware.Abstract;
using ComputerModel.Hardware.Concrete;
using ComputerModel.Software.Concrete;

namespace ComputerModel
{
    class Program
    {
        static void Main()
        {

            ComputerBox zalmanZ11 = StartComputer();

            zalmanZ11.InitHardware();

            Console.ReadLine();

        }

        public static ComputerBox StartComputer() => new ComputerBoxZalmanZ11(
            new AsrockH87(
                new IntelXeon(), 
                new KingstonRam(),
                new ZalmanOptima(100),
                new SamsungSsd(),
                new NVidia(), 
                new AsrockBios(2) 
            ),
            new ComputerBoxFanZalman(),
            new Chieftec()  
        );
    }
}
