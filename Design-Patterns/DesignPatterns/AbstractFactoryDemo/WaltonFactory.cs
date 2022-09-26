using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryDemo
{
    public class WaltonCar : ICar
    {
        public void Manufacture() { }
    }
    public class WaltonBike : IBike
    {
        public void Manufacture() { }
    }
    public class WaltonFactory : VehicleFactory
    {
        public override ICar GetCar()
        {
            return new WaltonCar();
        }
        public override IBike GetBike()
        {
            return new WaltonBike();
        }
    }
}
