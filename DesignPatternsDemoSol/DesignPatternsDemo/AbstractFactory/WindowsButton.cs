namespace DesignPatternsDemo.AbstractFactory
{
    public class WindowsButton : IButton
    {
        public void Click() => Console.WriteLine("Windows button clicked!");
    }
}
