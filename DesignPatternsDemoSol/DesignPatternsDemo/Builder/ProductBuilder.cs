namespace DesignPatternsDemo.Builder
{
    public class ProductBuilder
    {
        private Product _product = new Product();

        public ProductBuilder SetName(string name)
        {
            _product.Name = name;
            return this;
        }

        public ProductBuilder SetDescription(string description)
        {
            _product.Description = description;
            return this;
        }

        public ProductBuilder SetCategory(string category)
        {
            _product.Category = category;
            return this;
        }

        public Product Build() => _product;
    }
}
