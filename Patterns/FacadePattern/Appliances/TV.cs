namespace Patterns.FacadePattern.Appliances
{
    public class TV : ITV
    {
        private bool _on;

        public TV()
        {
            _on = false;
        }

        public void TurnOn()
        {
            _on = true;
        }

        public void TurnOff()
        {
            _on = false;
        }

        public bool IsOn()
        {
            return _on;
        }
    }
}
