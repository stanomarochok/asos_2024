namespace DesignPatternsDemo.Creational.AbstractFactory
{
    public class MacOSButton : IButton
    {
        public void Click() => Console.WriteLine("MacOS button clicked!");
    }
}
