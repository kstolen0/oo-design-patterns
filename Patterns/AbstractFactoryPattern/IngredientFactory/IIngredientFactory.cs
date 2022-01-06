using Patterns.AbstractFactoryPattern.IngredientFactory.Cheese;

namespace Patterns.AbstractFactoryPattern.IngredientFactory
{
    public interface IIngredientFactory
    {
        ICheese CreateCheese();
    }
}
