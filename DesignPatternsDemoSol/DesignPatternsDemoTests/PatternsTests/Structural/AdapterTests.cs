using DesignPatternsDemo.Structural.Adapter;

namespace DesignPatternsDemoTests.PatternsTests.Structural
{
    [TestFixture]
    public class AdapterTests
    {
        [Test]
        public void Adapter_Demo()
        {
            Adaptee adaptee = new Adaptee();
            ITarget adapter = new Adapter(adaptee);

            adapter.Request();
        }

        [Test]
        public void Adapter_MockAdaptee()
        {
            //var adapteeMock = new Mock<Adaptee>();
            //adapteeMock.Setup(x => x.SpecificRequest()).Returns("Special Output");

            //ITarget adapter = new Adapter(adapteeMock.Object);
            //adapter.Request();

            //adapteeMock.Verify(x => x.SpecificRequest(), Times.Once);
        }
    }
}
