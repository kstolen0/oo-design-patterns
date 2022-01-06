using FluentAssertions;
using Patterns.AbstractFactoryPattern.Pizzas;
using Patterns.AbstractFactoryPattern.PizzaStores;
using Xunit;

namespace UnitTests
{
    public class AbstractFactoryTests
    {
        [Fact]
        public void CreatePizzaStore()
        {
            IPizzaStore sut = new NewYorkPizzaStore();
        }

        [Fact]
        public void OrderCheesePizza()
        {
            IPizzaStore sut = new NewYorkPizzaStore();

            var result = sut.OrderPizza("Cheese");

            result.GetType().Should().Be(typeof(CheesePizza));
        }

        [Fact]
        public void NYStylePizzasHaveNYIngredients()
        {
            IPizzaStore sut = new NewYorkPizzaStore();

            IPizza result = sut.OrderPizza("Cheese");

            result.Cheese.Description.Should().BeEquivalentTo("NY style cheese");
        }
    }
}
