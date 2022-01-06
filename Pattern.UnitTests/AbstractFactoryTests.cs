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
            PizzaStore sut = new NewYorkPizzaStore();
        }

        [Fact]
        public void OrderCheesePizza()
        {
            PizzaStore sut = new NewYorkPizzaStore();

            var result = sut.OrderPizza(PizzaStore.Menu.Cheese);

            result.GetType().Should().Be(typeof(CheesePizza));
        }

        [Fact]
        public void OrderPepperoniPizza()
        {
            PizzaStore sut = new NewYorkPizzaStore();

            var result = sut.OrderPizza(PizzaStore.Menu.Pepperoni);

            result.GetType().Should().Be(typeof(PepperoniPizza));
        }

        [Fact]
        public void NYCheesePizzaHasNYToppings()
        {
            PizzaStore sut = new NewYorkPizzaStore();

            IPizza result = sut.OrderPizza(PizzaStore.Menu.Cheese);

            result.Cheese.Should().BeOfType<NewYorkStyleCheese>();
        }

        [Fact]
        public void NYPepperoniPizzaHasNYToppings()
        {
            PizzaStore sut = new NewYorkPizzaStore();

            IPizza result = sut.OrderPizza(PizzaStore.Menu.Pepperoni);

            result.Cheese.Should().BeOfType<NewYorkStyleCheese>();
            result.Pepperoni.Should().BeOfType<NewYorkStylePepperoni>();
        }

        [Fact]
        public void CreateChicagoPizza()
        {
            PizzaStore sut = new ChicagoPizzaStore();
        }

        [Fact]
        public void ChicagoCheesePizzaHasChicagoToppings()
        {
            PizzaStore sut = new ChicagoPizzaStore();

            IPizza result = sut.OrderPizza(PizzaStore.Menu.Cheese);

            result.Cheese.Should().BeOfType<ChicagoStyleCheese>();
        }

        [Fact]
        public void ChicagoPepperoniPizzaHasChicagoToppings()
        {
            PizzaStore sut = new ChicagoPizzaStore();

            IPizza result = sut.OrderPizza(PizzaStore.Menu.Pepperoni);

            result.Cheese.Should().BeOfType<ChicagoStyleCheese>();
            result.Pepperoni.Should().BeOfType<ChicagoStylePepperoni>();
        }
    }
}
