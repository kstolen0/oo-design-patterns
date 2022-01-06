using Patterns.AbstractFactoryPattern.IngredientFactory.Cheese;
using Patterns.AbstractFactoryPattern.IngredientFactory.Pepperoni;

namespace Patterns.AbstractFactoryPattern.IngredientFactory
{
    public class NewYorkIngredientFactory : IIngredientFactory
    {
        public ICheese CreateCheese()
        {
            return new NewYorkStyleCheese();
        }

        public IPepperoni CreatePepperoni()
        {
            return new NewYorkStylePepperoni();
        }
    }
}
