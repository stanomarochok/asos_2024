namespace DesignPatternsDemo.Builder
{
    public class Product
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string Category { get; set; }

        public Product() { }

        public Product(string name, string description, string category) {
            Name = name;
            Description = description;
            Category = category;
        }

        public void Show() => Console.WriteLine($"{Name} {Description} {Category}");
    }
}
