namespace DesignPatternsDemo.Structural.Bridge
{
    public class Radio : IDevice
    {
        private bool _isEnabled;

        public bool IsEnabled() => _isEnabled;

        public void TurnOff()
        {
            _isEnabled = false;
            Console.WriteLine("Radio turned off.");
        }

        public void TurnOn()
        {
            _isEnabled = true;
            Console.WriteLine("Radio turned on.");
        }
    }
}
