namespace DesignPatternsDemo.Structural.Bridge
{
    public abstract class RemoteControl
    {
        protected readonly IDevice _device;

        public RemoteControl(IDevice device)
        {
            _device = device;
        }

        public abstract void TogglePower();
    }
}
