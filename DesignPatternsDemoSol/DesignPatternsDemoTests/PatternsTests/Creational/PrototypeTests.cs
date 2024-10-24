using DesignPatternsDemo.Creational.Prototype;

namespace DesignPatternsDemoTests.PatternsTests.Creational
{
    [TestFixture]
    public class PrototypeTests
    {
        [Test]
        public void Prototype_SameObjects()
        {
            var now = DateTime.Now;
            IPrototype nakup1 = new Nakup()
            {
                DateTime = now,
                Mlieko = new Mlieko()
                {
                    ExpirationDate = now.AddDays(2),
                    Manufacturer = "Slovakia",
                    Price = 5
                }
            };

            IPrototype nakup2 = nakup1;
            Assert.That(nakup2, Is.EqualTo(nakup1));

            IPrototype nakup3 = nakup1.Clone();
            Assert.That(nakup3, Is.Not.EqualTo(nakup1));
        }
    }
}
