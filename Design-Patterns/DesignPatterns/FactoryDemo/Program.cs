using System;

namespace FactoryDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            CarFactory carFactory = new CarFactory();
            ICar sixSeaterCar = carFactory.GetCar("SixSeater");
            ICar fourSeaterCar = carFactory.GetCar("FourSeater");
            sixSeaterCar.Start();
            fourSeaterCar.Start();
        }
    }
}
