using Patterns.FacadePattern.Appliances;

namespace Patterns.FacadePattern
{
    public class EntertainmentSystem : IEntertainmentSystem
    {
        public EntertainmentSystem(IRadio radio, ITV tv)
        {
            Radio = radio;
            Tv = tv;
        }

        public IRadio Radio { get; }
        public ITV Tv { get; }

        public void TurnOnRadio()
        {
            Tv.TurnOff();
            Radio.TurnOn();
        }

        public void TurnOnTV()
        {
            Radio.TurnOff();
            Tv.TurnOn();
        }
    }
}
