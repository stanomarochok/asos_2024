namespace DesignPatternsDemo.FactoryMethod
{
    public class FactoryProductB : ICreator
    {
        public IProduct CreateProduct() => new ConcreteProductB();
    }
}
