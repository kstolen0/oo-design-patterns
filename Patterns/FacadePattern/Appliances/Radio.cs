namespace Patterns.FacadePattern.Appliances
{
    public class Radio : IRadio
    {
        private bool _on;

        public Radio()
        {
            _on = false;
        }

        public bool IsOn()
        {
            return _on;
        }

        public void TurnOff()
        {
            _on = false;
        }

        public void TurnOn()
        {
            _on = true;
        }
    }
}
