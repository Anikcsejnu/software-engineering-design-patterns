using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryDemo
{
    public interface ICar
    {
        void Start();
    }

    public class SixSeaterCar : ICar
    {
        public void Start()
        {
            Console.WriteLine("Started six seater car");
        }
    }
    public class FourSeaterCar : ICar
    {
        public void Start()
        {
            Console.WriteLine("Started four seater car");
        }
    }

    public class CarFactory
    {
        public ICar GetCar(string carType)
        {
            switch (carType)
            {
                case "SixSeater":
                    return new SixSeaterCar();
                case "FourSeater":
                    return new FourSeaterCar();
            }
            return null;
        }
    }
}
