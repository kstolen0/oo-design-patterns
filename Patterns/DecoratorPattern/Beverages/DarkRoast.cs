namespace Patterns.DecoratorPattern.Beverages
{
    public class DarkRoast : IBeverage
    {
        public long Cost()
        {
            return (long)4.0;
        }
    }
}
