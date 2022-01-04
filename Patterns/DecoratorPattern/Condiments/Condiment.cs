using Patterns.DecoratorPattern.Beverages;

namespace Patterns.DecoratorPattern.Condiments
{
    public class Condiment : Beverage
    {
        protected Beverage _beverage;

        public Condiment(Beverage beverage)
        {
            _beverage = beverage;
        }

        public override long Cost()
        {
            throw new System.NotImplementedException();
        }
    }
}
