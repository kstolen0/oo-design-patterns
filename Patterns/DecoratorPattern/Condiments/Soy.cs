using Patterns.DecoratorPattern.Beverages;

namespace Patterns.DecoratorPattern.Condiments
{
    public class Soy : IDecorator
    {
        private IBeverage _beverage;

        public Soy(IBeverage beverage)
        {
            _beverage = beverage;
        }

        public long Cost()
        {
            return _beverage.Cost() + (long)0.5;
        }
    }
}
