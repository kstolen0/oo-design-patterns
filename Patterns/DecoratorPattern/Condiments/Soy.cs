using Patterns.DecoratorPattern.Beverages;

namespace Patterns.DecoratorPattern.Condiments
{
    public class Soy : Condiment
    {
        public Soy(Beverage beverage) : base(beverage)
        {
        }

        public override double Cost()
        {
            switch (_beverage.GetSize())
            {
                case (Size.SMALL):
                    return _beverage.Cost() + 0.5;
                case (Size.MEDIUM):
                    return _beverage.Cost() + 0.7;
                case (Size.LARGE):
                    return _beverage.Cost() + 1.0;
                default:
                    return _beverage.Cost() + 0.5;

            }
        }
    }
}
