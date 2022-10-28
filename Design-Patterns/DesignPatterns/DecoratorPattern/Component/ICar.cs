using System;
using System.Collections.Generic;
using System.Text;

namespace DecoratorDemo.Component
{
    public interface ICar
    {
        string Make { get; }
        double GetPrice();
    }
}
