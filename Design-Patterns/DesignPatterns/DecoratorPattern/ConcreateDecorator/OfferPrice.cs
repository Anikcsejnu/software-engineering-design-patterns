using DecoratorDemo.Component;
using DecoratorDemo.Decorator;
using System;
using System.Collections.Generic;
using System.Text;

namespace DecoratorDemo.ConcreateDecorator
{
    public class OfferPrice : CarDecorator
    {
        public OfferPrice(ICar car): base(car)
        {

        }
        public override double GetDiscounterPrice()
        {
            return .8 * base.GetPrice();
        }
    }
}
