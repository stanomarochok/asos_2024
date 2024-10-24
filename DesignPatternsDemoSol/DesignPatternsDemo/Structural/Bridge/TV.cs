namespace DesignPatternsDemo.Structural.Bridge
{
    public class TV : IDevice
    {
        private bool _isEnabled;

        public bool IsEnabled() => _isEnabled;

        public void TurnOff()
        {
            _isEnabled = false;
            Console.WriteLine("TV turned off.");
        }

        public void TurnOn()
        {
            _isEnabled = true;
            Console.WriteLine("TV turned on.");
        }
    }
}
