using Patterns.AbstractFactoryPattern.IngredientFactory;
using Patterns.AbstractFactoryPattern.IngredientFactory.Cheese;

namespace Patterns.AbstractFactoryPattern.Pizzas
{
    public class CheesePizza : IPizza
    {
        public ICheese Cheese { get; }

        public CheesePizza(IIngredientFactory ingredients)
        {
            Cheese = ingredients.CreateCheese();
        }
    }
}
