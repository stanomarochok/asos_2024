using DesignPatternsDemo.FactoryMethod;

namespace DesignPatternsDemoTests.PatternsTests
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