namespace DesignPatternsDemo.Creational.AbstractFactory
{
    public class WindowsCheckbox : ICheckbox
    {
        public void Check() => Console.WriteLine("Windows checkbox checked!");
    }
}
