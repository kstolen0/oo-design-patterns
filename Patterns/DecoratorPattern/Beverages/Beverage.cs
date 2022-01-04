namespace Patterns.DecoratorPattern.Beverages
{
    public abstract class Beverage
    {
        public enum Size { SMALL, MEDIUM, LARGE };
        protected Size _size;

        public abstract double Cost();

        public virtual void SetSize(Size size)
        {
            _size = size;
        }

        public virtual Size GetSize()
        {
            return _size;
        }
    }
}
