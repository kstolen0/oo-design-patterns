using Patterns.AbstractFactoryPattern.IngredientFactory.Cheese;
using Patterns.AbstractFactoryPattern.Pizzas;

namespace Patterns.AbstractFactoryPattern.PizzaStores
{
    public class NewYorkPizzaStore : IPizzaStore
    {
        public IPizza OrderPizza(string type)
        {
            return new CheesePizza(new NewYorkStyleCheese());
        }
    }
}
