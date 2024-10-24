using DesignPatternsDemo.Creational.AbstractFactory;

namespace DesignPatternsDemoTests.PatternsTests.Creational
{
    [TestFixture]
    public class AbstractFactoryTests
    {
        [Test]
        public void AbstractFactory_Demo()
        {
            IGUIFactory factory = new WindowsGUIFactory();

            var button = factory.CreateButton();
            var checkbox = factory.CreateCheckbox();

            Assert.That(button, Is.Not.Null);
            Assert.That(button, Is.TypeOf(typeof(WindowsButton)));

            Assert.That(checkbox, Is.Not.Null);
            Assert.That(checkbox, Is.TypeOf(typeof(WindowsCheckbox)));

            factory = new MacOSGUIFactory();

            button = factory.CreateButton();
            checkbox = factory.CreateCheckbox();

            Assert.That(button, Is.Not.Null);
            Assert.That(button, Is.TypeOf(typeof(MacOSButton)));

            Assert.That(checkbox, Is.Not.Null);
            Assert.That(checkbox, Is.TypeOf(typeof(MacOSCheckbox)));
        }
    }
}
