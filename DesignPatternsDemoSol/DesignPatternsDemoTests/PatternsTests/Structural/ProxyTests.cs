using DesignPatternsDemo.Structural.Proxy;

namespace DesignPatternsDemoTests.PatternsTests.Structural
{
    [TestFixture]
    public class ProxyTests
    {
        [Test]
        public void Proxy_Demo()
        {
            RealImage realImage = null;
            IImage image = new ProxyImage(realImage);
            image.Display();
        }
    }
}
