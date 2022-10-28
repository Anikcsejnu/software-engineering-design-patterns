using DecoratorDemo.Component;
using DecoratorDemo.ConcreateComponent;
using DecoratorDemo.ConcreateDecorator;
using DecoratorDemo.Decorator;
using System;

namespace DecoratorPattern
{
    public class Program
    {
        static void Main(string[] args)
        {
            ICar car = new Suzuki();
            CarDecorator decorator = new OfferPrice(car);

            Console.WriteLine(string.Format("Make: {0} Price: {1} Discount price: {2}",
                              decorator.Make, decorator.GetPrice().ToString(),
                              decorator.GetDiscounterPrice().ToString()));

            Console.ReadLine();
        }
    }
}
