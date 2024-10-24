namespace DesignPatternsDemo.Structural.Facade
{
    public class TV
    {
        public void TurnOn() => Console.WriteLine("TV turned on.");
        public void TurnOff() => Console.WriteLine("TV turned off.");
        public void PlayMovie(string movie) => Console.WriteLine($"Playing movie {movie}...");
        public void StopMovie() => Console.WriteLine($"Stopped movie.");
    }
}
