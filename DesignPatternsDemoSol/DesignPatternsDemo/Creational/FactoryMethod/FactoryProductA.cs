namespace DesignPatternsDemo.Creational.FactoryMethod
{
    public class FactoryProductA : ICreator
    {
        public IProduct CreateProduct() => new ConcreteProductA();
    }
}
