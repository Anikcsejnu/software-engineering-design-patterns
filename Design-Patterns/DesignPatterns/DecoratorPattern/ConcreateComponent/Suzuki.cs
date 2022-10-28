using DecoratorDemo.Component;
using System;
using System.Collections.Generic;
using System.Text;

namespace DecoratorDemo.ConcreateComponent
{
    public class Suzuki: ICar
    {
        public string Make
        {
            get { return "Sedan"; }
        }
        public double GetPrice()
        {
            return 800000;
        }
    }
}
