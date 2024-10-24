namespace DesignPatternsDemo.Structural.Proxy
{
    public class RealImage : IImage
    {
        public void Display()
        {
            Console.WriteLine("Real Image.");
        }
    }
}
