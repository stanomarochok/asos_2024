namespace DesignPatternsDemo.AbstractFactory
{
    public class MacOSCheckbox : ICheckbox
    {
        public void Check() => Console.WriteLine("MacOS checkbox checked!");
    }
}
