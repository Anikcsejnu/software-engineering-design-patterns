using DecoratorDemo.Component;
using System;
using System.Collections.Generic;
using System.Text;

namespace DecoratorDemo.Decorator
{
    public abstract class CarDecorator: ICar
    {
        private ICar _car;
        public CarDecorator(ICar Car)
        {
            _car = Car;
        }

        public string Make { get { return _car.Make; } }
        public double GetPrice()
        {
            return _car.GetPrice();
        }
        public abstract double GetDiscounterPrice();
    }
}
