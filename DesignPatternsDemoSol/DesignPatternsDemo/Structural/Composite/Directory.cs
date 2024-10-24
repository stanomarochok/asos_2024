namespace DesignPatternsDemo.Structural.Composite
{
    public class Directory : IFileSystemItem
    {
        private string _filename;
        private List<IFileSystemItem> _items = new List<IFileSystemItem>();

        public Directory(string filename)
        {
            _filename = filename;
        }

        public Directory(string filename, List<IFileSystemItem> items) : this(filename)
        {
            _items = items;
        }

        public void AddItem(IFileSystemItem item)
        {
            _items.Add(item);
        }

        public void Display(string indent)
        {
            Console.WriteLine($"{indent} +{_filename}");
            foreach (var item in _items)
            {
                item.Display($"{indent}  ");
            }
        }
    }
}
