namespace Patterns.DecoratorPattern.Beverages
{
    public class DarkRoast : IBeverage
    {
        public long Cost()
        {
            return (long)0.5;
        }
    }
}
