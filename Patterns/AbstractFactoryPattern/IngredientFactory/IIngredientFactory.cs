using Patterns.AbstractFactoryPattern.IngredientFactory.Cheese;
using Patterns.AbstractFactoryPattern.IngredientFactory.Pepperoni;
using Patterns.AbstractFactoryPattern.IngredientFactory.Sauce;

namespace Patterns.AbstractFactoryPattern.IngredientFactory
{
    public interface IIngredientFactory
    {
        ICheese CreateCheese();

        IPepperoni CreatePepperoni();

        ISauce CreateSauce();
    }
}
