using Patterns.AbstractFactoryPattern.IngredientFactory.Cheese;
using Patterns.AbstractFactoryPattern.IngredientFactory.Pepperoni;

namespace Patterns.AbstractFactoryPattern.IngredientFactory
{
    public interface IIngredientFactory
    {
        ICheese CreateCheese();

        IPepperoni CreatePepperoni();
    }
}
