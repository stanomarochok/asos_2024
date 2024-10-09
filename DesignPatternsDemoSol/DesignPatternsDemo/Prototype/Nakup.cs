namespace DesignPatternsDemo.Prototype
{
    public class Nakup : IPrototype
    {
        public DateTime DateTime { get; set; }
        public IPrototype Mlieko { get; set; }

        public IPrototype Clone()
        {
            return new Nakup()
            {
                DateTime = DateTime,
                Mlieko = Mlieko.Clone()
            };
        }
    }
}
