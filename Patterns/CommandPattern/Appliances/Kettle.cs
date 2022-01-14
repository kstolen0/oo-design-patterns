namespace Patterns.CommandPattern.Appliances
{
    public class Kettle
    {
        private bool _isWaterBoiled;

        public Kettle()
        {
            _isWaterBoiled = false;
        }

        public void Boil()
        {
            _isWaterBoiled = true;
        }

        public void StopBoiling()
        {
            _isWaterBoiled = false;
        }

        public bool IsWaterBoiled()
        {
            return _isWaterBoiled;
        }
    }
}
