using Patterns.DecoratorPattern.Beverages;

namespace Patterns.DecoratorPattern.Condiments
{
    public abstract class Condiment : Beverage
    {
        protected Beverage _beverage;

        public Condiment(Beverage beverage)
        {
            _beverage = beverage;
        }

        public abstract override double Cost();

        public override void SetSize(Size size)
        {
            _beverage.SetSize(size);
        }

        public override Size GetSize()
        {
            return _beverage.GetSize();
        }
    }
}
