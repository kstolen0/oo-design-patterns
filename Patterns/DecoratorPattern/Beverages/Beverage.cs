namespace Patterns.DecoratorPattern.Beverages
{
    public abstract class Beverage
    {
        public enum Size { SMALL, MEDIUM, LARGE };
        protected Size _size;

        public abstract long Cost();

        public void SetSize(Size size)
        {
            _size = size;
        }

        public Size GetSize()
        {
            return _size;
        }
    }
}
