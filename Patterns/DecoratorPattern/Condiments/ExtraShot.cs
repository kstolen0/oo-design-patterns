using Patterns.DecoratorPattern.Beverages;

namespace Patterns.DecoratorPattern.Condiments
{
    public class ExtraShot : Condiment
    {

        public ExtraShot(Beverage beverage) : base(beverage)
        {
        }

        public override double Cost()
        {
            return _beverage.Cost() + 1.0;
        }
    }
}
