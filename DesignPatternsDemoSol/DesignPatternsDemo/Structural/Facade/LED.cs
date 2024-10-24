using System.Drawing;

namespace DesignPatternsDemo.Structural.Facade
{
    public class LED
    {
        public void TurnOn() => Console.WriteLine("LED lights turned on.");
        public void TurnOff() => Console.WriteLine("LED lights turned off.");
        public void SetColor(Color color) => Console.WriteLine($"Color set to {color.Name}.");
    }
}
