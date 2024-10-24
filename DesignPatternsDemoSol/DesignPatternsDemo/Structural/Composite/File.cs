namespace DesignPatternsDemo.Structural.Composite
{
    public class File : IFileSystemItem
    {
        private string _filename;

        public File(string filename)
        {
            _filename = filename;
        }

        public void Display(string indent)
        {
            Console.WriteLine($"{indent} -{_filename}");
        }
    }
}
