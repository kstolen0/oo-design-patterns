using Patterns.AbstractFactoryPattern.IngredientFactory.Cheese;

namespace Patterns.AbstractFactoryPattern.IngredientFactory
{
    public class NewYorkIngredientFactory : IIngredientFactory
    {
        public ICheese CreateCheese()
        {
            return new NewYorkStyleCheese();
        }
    }
}
