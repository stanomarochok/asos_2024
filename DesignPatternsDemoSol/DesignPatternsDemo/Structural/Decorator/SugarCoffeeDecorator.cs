namespace DesignPatternsDemo.Structural.Decorator
{
    public class SugarCoffeeDecorator : CoffeeDecorator
    {
        public SugarCoffeeDecorator(ICoffee coffee) : base(coffee) { }

        public override double GetCost()
        {
            return base.GetCost() + 0.5;
        }

        public override string GetDescription()
        {
            return base.GetDescription() + ", Sugar";
        }
    }
}
