using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryDemo
{
    public class TeslaCar: ICar
    {
        public void Manufacture() { }
    }
    public class TeslaBike: IBike
    {
        public void Manufacture() { }
    }
    public class TeslaFactory : VehicleFactory
    {
        public override ICar GetCar()
        {
            return new TeslaCar();
        }
        public override IBike GetBike()
        {
            return new TeslaBike();
        }

    }
}
