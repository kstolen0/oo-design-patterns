using Patterns.AbstractFactoryPattern.IngredientFactory.Cheese;

namespace Patterns.AbstractFactoryPattern.Pizzas
{
    public class CheesePizza : IPizza
    {
        public ICheese Cheese { get; }

        public CheesePizza(ICheese cheese)
        {
            Cheese = cheese;
        }
    }
}
