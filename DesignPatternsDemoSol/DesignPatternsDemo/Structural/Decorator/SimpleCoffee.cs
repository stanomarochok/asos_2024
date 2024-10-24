namespace DesignPatternsDemo.Structural.Decorator
{
    public class SimpleCoffee : ICoffee
    {
        public double GetCost()
        {
            return 5.0;
        }

        public string GetDescription()
        {
            return "Simple Coffee";
        }
    }
}
