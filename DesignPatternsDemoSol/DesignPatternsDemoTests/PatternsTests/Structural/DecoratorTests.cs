using DesignPatternsDemo.Structural.Decorator;

namespace DesignPatternsDemoTests.PatternsTests.Structural
{
    [TestFixture]
    public class DecoratorTests
    {
        [Test]
        public void Decorator_Demo()
        {
            ICoffee coffee = new SimpleCoffee();
            Console.WriteLine($"{coffee.GetDescription()} : {coffee.GetCost()}");

            coffee = new MilkCoffeeDecorator(coffee);
            Console.WriteLine($"{coffee.GetDescription()} : {coffee.GetCost()}");

            coffee = new SugarCoffeeDecorator(coffee);
            Console.WriteLine($"{coffee.GetDescription()} : {coffee.GetCost()}");
        }
    }
}
