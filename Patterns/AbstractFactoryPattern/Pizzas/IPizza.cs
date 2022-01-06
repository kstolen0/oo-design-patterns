using Patterns.AbstractFactoryPattern.IngredientFactory.Cheese;
using Patterns.AbstractFactoryPattern.IngredientFactory.Pepperoni;
using Patterns.AbstractFactoryPattern.IngredientFactory.Sauce;

namespace Patterns.AbstractFactoryPattern.Pizzas
{
    public interface IPizza
    {
        ICheese Cheese { get; }

        IPepperoni Pepperoni { get; }

        ISauce Sauce { get; }
    }
}
