using Patterns.AbstractFactoryPattern.IngredientFactory;
using Patterns.AbstractFactoryPattern.Pizzas;

namespace Patterns.AbstractFactoryPattern.PizzaStores
{
    public abstract class PizzaStore
    {
        protected IIngredientFactory ingredientFactory;

        public IPizza OrderPizza(string type)
        {
            return new CheesePizza(ingredientFactory);
        }
    }
}
