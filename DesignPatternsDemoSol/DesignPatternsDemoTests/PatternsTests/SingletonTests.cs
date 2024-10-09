using DesignPatternsDemo.Singleton;

namespace DesignPatternsDemoTests.PatternsTests
{
    [TestFixture]
    public class SingletonTests
    {
        [Test]
        public void Singleton_SameInstance()
        {
            var instance1 = Singleton.GetInstance();
            var instance2 = Singleton.GetInstance();

            Assert.That(instance1, Is.EqualTo(instance2), "Singleton instances are not same.");
        }

        [Test]
        public void Singleton_Lock()
        {
            Singleton instance1 = null;
            Singleton instance2 = null;

            Parallel.Invoke(
                () => { instance1 = Singleton.GetInstance(); },
                () => { instance2 = Singleton.GetInstance(); }
            );

            Assert.That(instance1, Is.EqualTo(instance2), "Singleton is not thread safe.");
        }
    }
}