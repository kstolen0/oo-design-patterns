namespace Patterns.DecoratorPattern.Beverages
{
    public class DarkRoast : Beverage
    {
        public override double Cost()
        {
            return (long)4.0;
        }
    }
}
