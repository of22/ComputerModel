namespace ComputerModel.Hardware.Interfaces
{
    public abstract class Cpu
    {
        private readonly int gHz;
        private readonly int cores;
        public int GHz { get; set; }
        public int Cores { set; get; }

    }
}
