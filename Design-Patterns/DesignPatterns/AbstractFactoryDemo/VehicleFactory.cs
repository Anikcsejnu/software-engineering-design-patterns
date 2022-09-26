using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryDemo
{
    public interface ICar { };
    public interface IBike { };
    public abstract class VehicleFactory
    {
        public abstract ICar GetCar();
        public abstract IBike GetBike();
    }
}
