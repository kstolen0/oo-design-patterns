using Patterns.DecoratorPattern.Beverages;

namespace Patterns.DecoratorPattern.Condiments
{
    public class ExtraShot : Condiment
    {

        public ExtraShot(Beverage beverage) : base(beverage)
        {
        }

        public override long Cost()
        {
            return _beverage.Cost() + (long)1.0;
        }
    }
}
