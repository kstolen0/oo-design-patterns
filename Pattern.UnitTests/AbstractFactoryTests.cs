using FluentAssertions;
using Patterns.AbstractFactoryPattern.IngredientFactory.Cheese;
using Patterns.AbstractFactoryPattern.IngredientFactory.Pepperoni;
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
        public void OrderPepperoniPizza()
        {
            IPizzaStore sut = new NewYorkPizzaStore();

            var result = sut.OrderPizza("Pepperoni");

            result.GetType().Should().Be(typeof(PepperoniPizza));
        }

        [Fact]
        public void NYCheesePizzaHasNYToppings()
        {
            IPizzaStore sut = new NewYorkPizzaStore();

            IPizza result = sut.OrderPizza("Cheese");

            result.Cheese.Description.Should().BeEquivalentTo("NY style cheese");
            result.Cheese.Should().BeOfType<NewYorkStyleCheese>();
        }

        [Fact]
        public void NYPepperoniPizzaHasNYToppings()
        {
            IPizzaStore sut = new NewYorkPizzaStore();

            IPizza result = sut.OrderPizza("Pepperoni");

            result.Cheese.Should().BeOfType<NewYorkStyleCheese>();
            result.Pepperoni.Should().BeOfType<NewYorkStylePepperoni>();
        }
    }
}
