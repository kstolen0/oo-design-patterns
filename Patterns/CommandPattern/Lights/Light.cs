namespace Patterns.CommandPattern.Lights
{
    public abstract class Light
    {
        private bool _lightsOn;
        public void ToggleLights()
        {
            _ = _lightsOn == true ? _lightsOn = false : _lightsOn = true;
        }

        public bool IsLightOn()
        {
            return _lightsOn;
        }
    }
}
