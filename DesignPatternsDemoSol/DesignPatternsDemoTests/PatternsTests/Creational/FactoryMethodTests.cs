using DesignPatternsDemo.Creational.FactoryMethod;

namespace DesignPatternsDemoTests.PatternsTests.Creational
{
    [TestFixture]
    public class FactoryMethodTests
    {
        [Test]
        public void FactoryMethod_Basic()
        {
            var creator = new FactoryProductB();
            var product = creator.CreateProduct();

            product.Operation();
            Assert.Pass();
        }
    }
}