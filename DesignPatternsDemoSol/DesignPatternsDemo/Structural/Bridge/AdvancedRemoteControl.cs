namespace DesignPatternsDemo.Structural.Bridge
{
    public class AdvancedRemoteControl : RemoteControl
    {
        public AdvancedRemoteControl(IDevice device) : base(device) { }

        public override void TogglePower()
        {
            if (_device.IsEnabled())
            {
                _device.TurnOff();
                return;
            }

            _device.TurnOn();
        }
    }
}
