using Patterns.AbstractFactoryPattern.IngredientFactory;
using Patterns.AbstractFactoryPattern.Pizzas;

namespace Patterns.AbstractFactoryPattern.PizzaStores
{
    public class NewYorkPizzaStore : IPizzaStore
    {
        public IPizza OrderPizza(string type)
        {
            IIngredientFactory ingredientFactory = new NewYorkIngredientFactory();

            return new CheesePizza(ingredientFactory);
        }
    }
}
