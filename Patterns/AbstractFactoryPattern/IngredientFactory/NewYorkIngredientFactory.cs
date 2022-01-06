using Patterns.AbstractFactoryPattern.IngredientFactory.Cheese;
using Patterns.AbstractFactoryPattern.IngredientFactory.Pepperoni;
using Patterns.AbstractFactoryPattern.IngredientFactory.Sauce;

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

        public ISauce CreateSauce()
        {
            return new NewYorkStyleSauce();
        }
    }
}
