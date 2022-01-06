using Patterns.AbstractFactoryPattern.IngredientFactory.Cheese;

namespace Patterns.AbstractFactoryPattern.Pizzas
{
    public interface IPizza
    {
        ICheese Cheese { get; }
    }
}
