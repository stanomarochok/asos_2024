namespace DesignPatternsDemo.Structural.Facade
{
    public class Speakers
    {
        public void TurnOn() => Console.WriteLine("Speakers turned on.");
        public void TurnOff() => Console.WriteLine("Speakers turned off.");
        public void SetVolume(int volume) => Console.WriteLine($"Volume set to {volume}.");
    }
}
