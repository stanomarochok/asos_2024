namespace DesignPatternsDemo.FactoryMethod
{
    public class FactoryProductA : ICreator
    {
        public IProduct CreateProduct() => new ConcreteProductA();
    }
}
