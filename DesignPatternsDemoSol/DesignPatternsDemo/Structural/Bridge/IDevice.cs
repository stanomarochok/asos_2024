namespace DesignPatternsDemo.Structural.Bridge
{
    public interface IDevice
    {
        void TurnOn();
        void TurnOff();
        bool IsEnabled();
    }
}
