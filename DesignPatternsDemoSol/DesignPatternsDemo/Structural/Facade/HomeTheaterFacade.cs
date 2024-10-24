using System.Drawing;

namespace DesignPatternsDemo.Structural.Facade
{
    public class HomeTheaterFacade
    {
        private TV _tv;
        private Speakers _speakers;
        private LED _led;

        public HomeTheaterFacade(TV tv, Speakers speakers, LED led)
        {
            _tv = tv;
            _speakers = speakers;
            _led = led;
        }

        public void PlayMovie(string movie)
        {
            _tv.TurnOn();
            _speakers.TurnOn();
            _led.TurnOn();

            _speakers.SetVolume(20);
            _led.SetColor(Color.AliceBlue);
            _tv.PlayMovie(movie);
        }

        public void Stop()
        {
            _tv.TurnOff();
            _speakers.TurnOff();
            _led.TurnOff();
        }
    }
}
