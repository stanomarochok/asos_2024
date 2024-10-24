namespace DesignPatternsDemo.Structural.Decorator
{
    public class MilkCoffeeDecorator : CoffeeDecorator
    {
        public MilkCoffeeDecorator(ICoffee coffee) : base(coffee) { }

        public override double GetCost()
        {
            return base.GetCost() + 1.5;
        }

        public override string GetDescription()
        {
            return base.GetDescription() + ", Milk";
        }
    }
}
