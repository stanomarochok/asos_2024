using DesignPatternsDemo.Structural.Composite;
using Directory = DesignPatternsDemo.Structural.Composite.Directory;
using File = DesignPatternsDemo.Structural.Composite.File;

namespace DesignPatternsDemoTests.PatternsTests.Structural
{
    [TestFixture]
    public class CompositeTests
    {
        [Test]
        public void Composite_Demo()
        {
            var root = new Directory("root");
            var user = new Directory("user");
            var home = new Directory("home");

            IFileSystemItem file1 = new File("file1");
            IFileSystemItem file2 = new File("file1");
            IFileSystemItem file3 = new File("file1");

            root.AddItem(file1);
            root.AddItem(user);

            user.AddItem(file2);
            user.AddItem(home);

            home.AddItem(file3);

            root.Display("");
        }
    }
}
