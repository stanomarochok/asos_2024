namespace DesignPatternsDemo.Creational.FactoryMethod
{
    public class FactoryProductB : ICreator
    {
        public IProduct CreateProduct() => new ConcreteProductB();
    }
}
