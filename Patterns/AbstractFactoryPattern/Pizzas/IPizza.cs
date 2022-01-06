using Patterns.AbstractFactoryPattern.IngredientFactory.Cheese;
using Patterns.AbstractFactoryPattern.IngredientFactory.Pepperoni;

namespace Patterns.AbstractFactoryPattern.Pizzas
{
    public interface IPizza
    {
        ICheese Cheese { get; }

        IPepperoni Pepperoni { get; }
    }
}
