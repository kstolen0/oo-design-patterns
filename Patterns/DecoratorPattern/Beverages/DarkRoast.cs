namespace Patterns.DecoratorPattern.Beverages
{
    public class DarkRoast : Beverage
    {
        public override long Cost()
        {
            return (long)4.0;
        }
    }
}
