using DecoratorDemo.Component;
using System;
using System.Collections.Generic;
using System.Text;

namespace DecoratorDemo.ConcreateComponent
{
    public sealed class Hyundai: ICar
    {
        public string Make
        {
            get { return "HatchBack"; }
        }
        public double GetPrice()
        {
            return 800000;
        }
    }
}
