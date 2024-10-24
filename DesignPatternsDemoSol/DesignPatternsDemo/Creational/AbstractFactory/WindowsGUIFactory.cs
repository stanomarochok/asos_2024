namespace DesignPatternsDemo.Creational.AbstractFactory
{
    public class WindowsGUIFactory : IGUIFactory
    {
        public IButton CreateButton() => new WindowsButton();

        public ICheckbox CreateCheckbox() => new WindowsCheckbox();
    }
}
