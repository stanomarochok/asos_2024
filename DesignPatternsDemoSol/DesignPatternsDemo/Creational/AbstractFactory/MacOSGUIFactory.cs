namespace DesignPatternsDemo.Creational.AbstractFactory
{
    public class MacOSGUIFactory : IGUIFactory
    {
        public IButton CreateButton() => new MacOSButton();

        public ICheckbox CreateCheckbox() => new MacOSCheckbox();
    }
}
