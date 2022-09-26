using System;

namespace AbstractFactoryDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            VehicleFactory teslaFactory = new TeslaFactory();
            IBike teslaBike = teslaFactory.GetBike();
            ICar teslaCar = teslaFactory.GetCar();

            VehicleFactory waltonFactory = new WaltonFactory();
            IBike waltonBike = waltonFactory.GetBike();
            ICar waltonCar = waltonFactory.GetCar();
        }
    }
}
