namespace ComputerModel.Hardware.Abstract
{
    public abstract class PowerSupply
    {
        //public readonly int power; // ask how to deal with private readonly fields that have to be set up with Property set method  

        public int Power { set; get; }
    }
}
