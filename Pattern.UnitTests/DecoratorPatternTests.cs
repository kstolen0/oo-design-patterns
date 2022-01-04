using Patterns.DecoratorPattern.Beverages;
using Xunit;

namespace UnitTests
{
    public class DecoratorPatternTests
    {
        [Fact]
        public void CreateBeverage()
        {
            IBeverage sut = new DarkRoast();
        }
    }
}
